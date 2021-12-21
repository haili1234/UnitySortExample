using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortController : MonoBehaviour
{
    private static SortController _instance;

    public static SortController GetInstance()
    {
        return _instance;
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (_instance != this)
            {
                Debug.Log("warning: multiple Manager creating!");
                GameObject.Destroy(gameObject);
            }
        }
    }
    
    
}