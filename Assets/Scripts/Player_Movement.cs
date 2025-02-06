using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{

    public float speed = 20;
    public Vector2 banana_position;
    float distance;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 position = transform.position;
        Vector2 banana_position = transform.position;

        banana_position.x = 4.5985f;
        banana_position.y = 2.7878f;


        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        distance = Vector2.Distance(position, banana_position);

        if (distance < 2)
        {

            print("bnanan");

        }
        else {

            print("no babanbna");

        }

        transform.position = position;
    }
}
