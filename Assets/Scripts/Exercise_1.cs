using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Exercise_1 : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    private int minNumber = 0;
    private int maxNumber = 250;

    // This function will create a random number between 0 and 250
    public void CreateRandomNumber()
    {
        //Will show it on screen
        textMesh.text = Random.Range(minNumber, maxNumber).ToString();
    }
}
