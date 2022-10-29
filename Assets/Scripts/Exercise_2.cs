using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exercise_2 : MonoBehaviour
{
    public int number;
    public TextMeshProUGUI textMesh;
   

    // Update is called once per frame
    void Update()
    {
        //If we press space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //If we can divide it by 2 it's even

            if(number % 2 == 0)
            {
                textMesh.text = "Oh wow! this" + number + "is even, wow!";
            }
            else
            {
                //if not, then it's odd
                textMesh.text = "Who would have thought..." + number + " is odd! Outstanding!";
            }
        }
    }
}
