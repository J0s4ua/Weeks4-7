using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class Player_Movement : MonoBehaviour
{

    public float speed = 20;
    public Vector2 banana_position;
    public GameObject Gameobject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 position = transform.position;
        Vector2 banana_position = Gameobject.transform.position;



        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

        if (Vector2.Distance(position, banana_position) > 10)
        {

            print("bnanan");

        }
        else {

            print("no babanbna");

        }

        transform.position = position;
    }
}
