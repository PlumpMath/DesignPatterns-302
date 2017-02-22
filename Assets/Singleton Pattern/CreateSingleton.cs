using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSingleton : MonoBehaviour
{
    public GameObject prefab;

    public void InstantiateSingleton()
    {
        Instantiate(prefab);
    }
}
