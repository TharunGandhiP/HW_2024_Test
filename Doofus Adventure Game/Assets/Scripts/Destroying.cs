using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroying : MonoBehaviour
{
    public GameObject AnObject;
    public float Lifetime = 7f;
    void Start()
    {
        Destroy(AnObject, Lifetime);
    }

    void Update()
    {
        
    }
}
