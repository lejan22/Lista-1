using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_5 : MonoBehaviour
{
    public Vector3[] positions;
    public GameObject Capsule;
 
    // Update is called once per frame
    void Update()
    {
        //If we press the S key
        if (Input.GetKeyDown(KeyCode.S))
        {
           
            //We create a capsule where we specified
            foreach (Vector3 pos in positions)
            {
                Instantiate(Capsule, pos, Capsule.transform.rotation);
            }

           
        }
    }
}
