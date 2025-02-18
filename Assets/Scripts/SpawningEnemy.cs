using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;
using TMPro;

public class SpawningEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider Progress2;
    public GameObject enemy;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            Instantiate(enemy);

            gameObject.SetActive(false);
        
    }
}
