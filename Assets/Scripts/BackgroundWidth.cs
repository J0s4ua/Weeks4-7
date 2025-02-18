using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;
using TMPro;

public class BackgroundWidth : MonoBehaviour
{
    // Start is called before the first frame update

    
    public Slider Progress2; //this is the slider, the main part of this program. This code will set up the game object to this variable to track its value.


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position; //sets up the pos variable
        pos.x = Progress2.value*-2; //moves the position of the bg based on the progress meter


        transform.position = pos; //sets the position in transform
        

    }
}
