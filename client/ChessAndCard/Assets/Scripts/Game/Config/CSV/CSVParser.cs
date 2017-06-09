using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace Core.CSV
{
    public class CSVParser<T> where T : new()
    {
        static public Dictionary<object, T> Parse(string sourceText)
        {
			Dictionary<object, T> result = new Dictionary<object, T>();

            string[] lineList = sourceText.Split('\n');
            string[] keyList = null;

            for (int i = 0, n = lineList.Length; i < n; i++)
            {
                string line = lineList[i].Trim();
                if (line.Length <= 0)
                {
                    continue;
                }
                if (i >= 2)
                { //数据
                    T record = new T();
                    string[] itemList = ParseLine(line);
                    ParseRecord(keyList, itemList, record);
                    result[int.Parse(itemList[0])] = record;
                    continue;
                }
                if (0 == i)
                {//key
                    keyList = ParseLine(line);
                    continue;
                }
            }

            return result;
        }

        static private string[] ParseLine(string line)
        {
            string[] itemList = line.Split('|');
            string[] result = new string[itemList.Length];
            for (int i = 0, n = itemList.Length; i < n; i++)
            {
                result[i] = itemList[i].Trim();
            }
            return result;
        }

        static private void ParseRecord(string[] keyList, string[] itemList, object record)
        {
            Type type = record.GetType();
            for (int i = 0, n = itemList.Length; i < n; i++)
            {
                string key = keyList[i];
                FieldInfo field = type.GetField(key);
                if (field != null)
                {
                    field.SetValue(record, CastType(itemList[i], field.FieldType));
                    continue;
                }
                PropertyInfo prop = type.GetProperty(key);
                if (prop != null && prop.CanWrite)
                {
                    //if (prop.PropertyType == typeof(LitJson.JsonData))
                    //{
                        
                    //}
                    //else 
                    {
                        prop.SetValue(record, CastType(itemList[i], prop.PropertyType), null);
                    }           
                }
            }
        }

        static private object CastType(string value, Type type)
        {
            if (type.Equals(typeof(System.Int32)))
            {
                return int.Parse(value);
            }
            if (type.Equals(typeof(System.Boolean)))
            {
                return Boolean.Parse(value);
            }
            if (type.Equals(typeof(System.Single)))
            {
                return float.Parse(value);
            }
            if (type.Equals(typeof(LitJson.JsonData))) 
            {
                return LitJson.JsonMapper.ToObject(value);
            }
            return value;
        }
    }

    public class BaseTemplate
    {
    }
}