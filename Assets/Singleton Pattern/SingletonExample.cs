using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonExample : MonoBehaviour
{
    public static SingletonExample instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
        {
            GenericUIManager.ChangeText("Singleton Instance already exists!");
            Destroy(gameObject);
        }


        DontDestroyOnLoad(gameObject);         
    }
}
