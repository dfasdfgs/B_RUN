using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move: MonoBehaviour
{
    public float Speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
}
