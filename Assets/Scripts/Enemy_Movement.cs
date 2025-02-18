using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;
using TMPro;

public class Enemy_Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float distance = 1;
    public GameObject explosion;
    public GameObject bullet;

    void Start()
    {
        explosion.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x = 20 - distance;
        distance += 1*Time.deltaTime;

        if (distance >= 16)
        {

            Instantiate(bullet);
            

        }

        if (distance >= 16) {

            explosion.gameObject.SetActive(true);
            distance = 16;
            Destroy(gameObject, 0.25f);
        
        }
        transform.position = pos;
    }
}
