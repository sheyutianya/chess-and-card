using UnityEngine;
using System.Collections;

//X.X.X.X 每个位意义：前两位留作项目版本，第三位为BUG修复版本，第四位为资源更新版本，前三位版本号变更都需要重新安装，第四位变更时客户端只需下载最新资源即可
public class VersionMgr
{
    private static VersionMgr s_instance = null;
    public static VersionMgr Instance
    {
        get
        {
            if (s_instance == null)
            {
                s_instance = new VersionMgr();
            }
            return s_instance;
        }
    }

    private int m_version = 1001;
    public int Version
    {
        get { return m_version; }
        set { m_version = value; }
    }

    private string str_version = "1.0.0.1"; 
    public string VersionStr
    {
        get { return str_version; }
        set { str_version = value; }
    }

}
