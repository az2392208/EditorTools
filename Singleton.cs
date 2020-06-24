using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> where T : new()
{
    //非monolei的单例
    private static T _instance;
    public static T Instance
    {
        get
        {
            if(_instance==null)
            {
                _instance = new T();
            }
            return _instance;
        }
    }
}
