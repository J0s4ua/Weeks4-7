using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;
using TMPro;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    
    public Slider Progress2; //this is the slider, the main part of this program. This code will set up the game object to this variable to track its value.


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position; //this will set up the pos variable
        Progress2.value += 1f * Time.deltaTime; //this will make it passively go up
        print("value = " + Progress2.value); //debug stuff to check if the value is going up
        
        
    }
}
