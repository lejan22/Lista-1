using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise_9 : MonoBehaviour
{
    public Toggle lightswitch;

    public GameObject directionLight;

    // Start is called before the first frame update
    void Start()
    {
        TurnLight(lightswitch.isOn);
    }

    public void TurnLight (bool isOn)
    {
        if (isOn)
        {
            directionLight.GetComponent<Light>().enabled = true;
        }
        else
        {
            directionLight.GetComponent<Light>().enabled = false;
        }
    }
}
