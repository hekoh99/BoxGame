using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayScript : MonoBehaviour
{
    private RaycastHit hit; //RaycastHit 라는 기능을 hit이라고 부르기로 함.
    private float MaxDistance = 15f;  //
    [HideInInspector]
    public int score = 0;
    private UnityEngine.Color preColor;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        preColor = GameObject.FindGameObjectWithTag("Box").GetComponent<MeshRenderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position, transform.up, out hit, MaxDistance))
        {
            if(hit.transform.gameObject.tag == "Box")
            {
                target = hit.transform;
                score = 1;
                hit.transform.GetComponent<MeshRenderer>().material.color = Color.red;
            }
            else if(score == 1 && hit.transform.gameObject.tag != "Box")
            {
                score = 0;
                target.GetComponent<MeshRenderer>().material.color = preColor;
            }
        }
        
    }
    
}
