using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_7 : MonoBehaviour
{
    public GameObject spookysphere;

    private Material BooMat;
    // Start is called before the first frame update
    void Start()
    {
        //Getting the material
        BooMat = spookysphere.GetComponent<Renderer>().material;
    }

    //Changes the transparency with the slider
    public void GetSpooky(float value)
    {
        BooMat.color = new Vector4(BooMat.color.r, BooMat.color.g, BooMat.color.b, value);
    }
}
