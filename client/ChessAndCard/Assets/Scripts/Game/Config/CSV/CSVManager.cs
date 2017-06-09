using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Core.CSV
{
    public class CSVManager:Singleton<CSVManager>
    {

        Hashtable dict;

        public CSVManager()
        {
            dict = new Hashtable();
        }

        public void Register<T>(string csvText) where T : new()
        {
            dict.Add(typeof(T), CSVParser<T>.Parse(csvText));
        }

        public void Register<T>(string csvText , string filedata) where T : new()
        {
            dict.Add(typeof(T), CSVParser<T>.Parse(csvText));
        }

        public Dictionary<object, T> GetCsv<T>()
        {
			return (Dictionary<object, T>)dict[typeof(T)];
        }

        public T GetData<T>(int itemId)
        {
            return GetCsv<T>()[itemId];
        }
    }
}