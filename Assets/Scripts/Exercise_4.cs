using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_4 : MonoBehaviour
{
    //We take the sphere
    public GameObject ball;


    public void Changesize(float value)
    {
        //We change the scale of the ball
        ball.transform.localScale = new Vector3(value, value, value);
    }
}
