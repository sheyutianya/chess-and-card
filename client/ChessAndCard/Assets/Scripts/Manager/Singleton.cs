/*
 * 游戏单例对象
 * 
 * Author: lolex
 * 
 */

using System;

public class Singleton<T> where T : new()
{
    protected static T instance;

    static Singleton()
    {
        T local = default(T);
        Singleton<T>.instance = (local == null) ? Activator.CreateInstance<T>() : default(T);
    }

    protected Singleton()
    {
    }

    public static T Instance
    {
        get
        {
            return Singleton<T>.instance;
        }
    }
}
