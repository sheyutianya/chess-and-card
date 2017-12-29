using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProtobufOut
{
    public partial class Form1 : Form
    {

        private string[] infoList = new string[6];
        private string configFilePath;
        private List<System.Windows.Forms.CheckBox> boxList = null;
        private string xlsName = "";
        private string xlsPath = "";
        private string[] protoFilePaths;
        private string[] protoFileNames;
        public Form1()
        {
            string appPath = Application.StartupPath;
            configFilePath = appPath + "\\config.txt";

            FileStream fs2 = new FileStream(configFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs2);
            int index = 0;
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)
                {
                    break;
                }
                infoList[index] = line;
                index++;
                if (index >= infoList.Length)
                    break;
            }
            fs2.SetLength(0);
            sr.Close();
            fs2.Close();

            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择数据文件";
            fileDialog.Filter = "数据表文件(*.xls*)|*.xls*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string sqlFile = fileDialog.FileName;
                xlsName = fileDialog.SafeFileName;
                xlsPath = sqlFile.Replace(xlsName, "");
                string[] nameList = ToDataTable(sqlFile);
                if (nameList == null)
                {
                    MessageBox.Show("找不到table,请确认一下表");
                    return;
                }


                button1.Visible = false;
                button7.Visible = false;
                checkBox1.Visible = false;
                panel1.Visible = true;

                int len = nameList.Length;
                boxList = new List<CheckBox>();
                for (int i = 0; i < len; i++)
                {
                    System.Windows.Forms.CheckBox box = new System.Windows.Forms.CheckBox();
                    box.Text = nameList[i];
                    flowLayoutPanel1.Controls.Add(box);
                    boxList.Add(box);
                }
            }
        }

        public static string[] ToDataTable(string filePath)
        {
            string connStr = "";
            string[] nameList = null;
            connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filePath + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";

            OleDbConnection conn = null;
            DataTable dtSheetName = null;

            DataSet ds = new DataSet();
            try
            {
                // 初始化连接，并打开
                conn = new OleDbConnection(connStr);
                conn.Open();

                // 获取数据源的表定义元数据                        
                string SheetName = "";
                dtSheetName = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });

                nameList = new string[dtSheetName.Rows.Count];
                // 初始化适配器
                for (int i = 0; i < dtSheetName.Rows.Count; i++)
                {
                    SheetName = (string)dtSheetName.Rows[i]["TABLE_NAME"];
                    nameList[i] = SheetName.Replace("$", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取表结构错误" + ex.ToString());
            }
            finally
            {
                // 关闭连接
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            return nameList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择C#文件存储路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                infoList[0] = "c# Path=" + dialog.SelectedPath;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择bytes文件存储路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                infoList[1] = "bytes Path=" + dialog.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择bat文件存储路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.SelectedPath + "/test.bat"))
                {
                    infoList[2] = "bat Path=" + dialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("没有找到test.bat");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> tableName = new List<string>();

            int len = boxList.Count;
            int i = 0;
            for (i = 0; i < len; i++)
            {

                if (boxList[i].Checked)
                {

                    tableName.Add(boxList[i].Text);
                }
            }
            len = tableName.Count;


            if (len == 0)
            {

                MessageBox.Show("至少选择一个表");
                return;
            }

            if (infoList[0] == null || infoList[0].Length == 0)
            {
                MessageBox.Show("没有设置c#的路径");
                return;
            }
            if (infoList[1] == null || infoList[1].Length == 0)
            {
                MessageBox.Show("没有设置bytes的路径");
                return;
            }
            if (infoList[2] == null || infoList[2].Length == 0)
            {
                MessageBox.Show("没有设置bat的路径");
                return;
            }


            string c_path = infoList[0].Replace("c# Path=", "");
            string bytes_path = infoList[1].Replace("bytes Path=", "");
            string batPath = infoList[2].Replace("bat Path=", "");
            string batPaths = batPath + "/test.bat";
            if (!File.Exists(batPaths))
            {

                MessageBox.Show("没有找到test.bat");
                return;
            }


            int pause = 0;

            if (checkBox1.Checked) {

                pause = 1;
            }

            for (i = 0; i < len; i++)
            {
                Process proc = null;
                try
                {
                    proc = new Process();
                    proc.StartInfo.WorkingDirectory = batPath;
                    proc.StartInfo.FileName = "test.bat";
                    proc.StartInfo.Arguments = " " + xlsName + " " + xlsPath + " " + tableName[i] + " " + c_path + " " + bytes_path + " " + pause;
                    proc.StartInfo.CreateNoWindow = false;
                    proc.Start();
                    proc.WaitForExit();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("创建cmd线程出错！我也不知道为啥！检测控制台是否正确启动" + ex.ToString());
                }
            }

            while (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.RemoveAt(0);
            }

            button1.Visible = true;
            button7.Visible = true;
            checkBox1.Visible = true; 
            panel1.Visible = false;


        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs2 = new FileStream(configFilePath, FileMode.Open, FileAccess.ReadWrite);
            StreamWriter config = new StreamWriter(fs2);
            for (int i = 0; i < 6; i++)
            {
                config.WriteLine(infoList[i]);
            }
            config.Close();
            fs2.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "proto文件";
            fileDialog.Filter = "proto文件(*.proto*)|*.proto*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                protoFilePaths = fileDialog.FileNames;
                protoFileNames = fileDialog.SafeFileNames;
                panel2.Visible = true;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择bat文件存储路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(dialog.SelectedPath + "/test1.bat"))
                {
                    infoList[3] = "bat Path=" + dialog.SelectedPath;
                }
                else
                {
                    MessageBox.Show("没有找到test1.bat");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择C#文件存储路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                infoList[4] = "c# Path=" + dialog.SelectedPath;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (infoList[4] == null || infoList[4].Length == 0)
            {
                MessageBox.Show("没有设置c#的路径");
                return;
            }
            if (infoList[3] == null || infoList[3].Length == 0)
            {
                MessageBox.Show("没有设置bat的路径");
                return;
            }
            if (infoList[5] == null || infoList[5].Length == 0)
            {
                MessageBox.Show("没有设置proto的根路径");
                return;
            }
            string batPath = infoList[3].Replace("bat Path=", "");
            string c_path = infoList[4].Replace("c# Path=", "");
            string proto_path = infoList[5].Replace("proto# Path=", "");
            string batPaths = batPath + "/test1.bat";
            string filName = "";
            if (!File.Exists(batPaths))
            {

                MessageBox.Show("没有找到test1.bat");
                return;
            }

            int pause = 0;

            if (checkBox1.Checked)
            {

                pause = 1;
            }
            for (int i = 0; i < protoFilePaths.Length; i++)
            {
                Process proc = null;
                try
                {
                    proc = new Process();
                    proc.StartInfo.WorkingDirectory = batPath;
                    proc.StartInfo.FileName = "test1.bat";
                    filName = protoFileNames[i].Substring(0, protoFileNames[i].IndexOf("."));
                    proc.StartInfo.Arguments = " " + filName + " " + c_path + " " + protoFilePaths[i] + " " + proto_path + " " + pause;
                    proc.StartInfo.CreateNoWindow = false;
                    proc.Start();
                    proc.WaitForExit();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("创建cmd线程出错！我也不知道为啥！检测控制台是否正确启动" + ex.ToString());
                }
            }


            button1.Visible = true;
            button7.Visible = true;
            checkBox1.Visible = true;
            panel2.Visible = false;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择proto文件根存储路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                infoList[5] = "proto# Path=" + dialog.SelectedPath;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

    }


}
