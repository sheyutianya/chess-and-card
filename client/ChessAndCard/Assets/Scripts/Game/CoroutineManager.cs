using System.Collections;
using UnityEngine;


internal class CoroutineManagerMonoBehaviour : MonoBehaviour
{
}
/***
 *  
 *   用于不继承MonoBehaviour的类 使用协程
 * */
public class CoroutineManager
{
    private static CoroutineManagerMonoBehaviour _CoroutineManagerMonoBehaviour;
     static CoroutineManager()
    {
        Init();
    }
    public static void StartCoroutine(IEnumerator routine)
    {
        _CoroutineManagerMonoBehaviour.StartCoroutine(routine);
    }
    public static void StartCoroutine(string methodName,object obj)
    {
        _CoroutineManagerMonoBehaviour.StartCoroutine(methodName,obj);
    }
    public static void StopStartCoroutine(IEnumerator routine)
    {

        _CoroutineManagerMonoBehaviour.StopCoroutine(routine);

    }
    public static void StopStartCoroutine(string methodName)
    {
        _CoroutineManagerMonoBehaviour.StopCoroutine(methodName);
    }
    public static void StopAllCoroutine()
    {
        _CoroutineManagerMonoBehaviour.StopAllCoroutines();
    }



    private static void Init()
    {
        var go = new GameObject();
        go.name = "CoroutineManager";
        _CoroutineManagerMonoBehaviour = go.AddComponent<CoroutineManagerMonoBehaviour>();
        GameObject.DontDestroyOnLoad(go);
    }


}