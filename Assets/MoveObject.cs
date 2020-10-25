using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveObject();   
    }

    void moveObject()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * (speed * Time.smoothDeltaTime * keyHorizontal), Space.World);
        transform.Translate(Vector3.forward * (speed * Time.smoothDeltaTime * keyVertical), Space.World);
    }
}
