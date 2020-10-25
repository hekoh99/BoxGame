using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Image;

    public RayScript Plane01;
    public RayScript Plane02;
    public RayScript Plane03;
    public RayScript Plane04;
    public RayScript Plane05;
    // Start is called before the first frame update
    void Start()
    {
        Plane01 = GameObject.Find("Plane (2)").GetComponent<RayScript>();
        Plane02 = GameObject.Find("Plane (3)").GetComponent<RayScript>();
        Plane03 = GameObject.Find("Plane (4)").GetComponent<RayScript>();
        Plane04 = GameObject.Find("Plane (5)").GetComponent<RayScript>();
        Plane05 = GameObject.Find("Plane (6)").GetComponent<RayScript>();
    }

    // Update is called once per frame
    void Update()
    {
        int sum = 0;
        sum = Plane01.score + Plane02.score + Plane03.score + Plane04.score + Plane05.score;
        if(sum == 5)
        {
            Image.SetActive(true);
        }
        else
        {
            Image.SetActive(false);
        }
    }
}
