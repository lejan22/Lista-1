using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_3 : MonoBehaviour
{
    private float Xpos;
    private float Ypos;
    private float Zpos;
    private float xRange = 4f;
    private float yRange = 4f;
    private float zRange = 4f;

   
    // Update is called once per frame
    void Update()
    {
        //If we press enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //We adjust the randomized location with each axis
            Xpos = Random.Range(-xRange, xRange);
            Ypos = Random.Range(-yRange, yRange);
            Zpos = Random.Range(-zRange, zRange);

            //It creates the randomized location
            transform.position = new Vector3(Xpos, Ypos, Zpos);
        }
    }
}
