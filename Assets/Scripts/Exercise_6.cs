using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_6 : MonoBehaviour
{
    public GameObject cilinder;
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        //Getting the material
        mat = cilinder.GetComponent<Renderer>().material;
    }
    //Choosing a color for each option on the dropdown
    public void ChangeColor(int index)
    {
        switch (index)
        {
            case 0:
                mat.color = Color.red;
                break;

            case 1:
                mat.color = Color.cyan;
                break;

            case 2:
                mat.color = Color.green;
                break;

            case 3:
                mat.color = Color.magenta;
                break;

            case 4:
                mat.color = Color.yellow;
                break;

            case 5:
                mat.color = Color.gray;
                break;

        }
    }
}
