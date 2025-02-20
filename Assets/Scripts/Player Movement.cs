using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 60f;
    public float velocity = 0;
    public SpriteRenderer rend;
    public bool onGround;
    public GameObject platform;
    public float direction;
    public float facing = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 pos2 = platform.transform.position;

        print(pos2.y);



        direction += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

        

        if (pos.y > platform.transform.position.y + 2) {

            
            velocity -= 0.4f;
        
        }

        if (pos.y <= platform.transform.position.y + 2)
        {

            velocity = 0;

        }


        if (Input.GetKeyDown(KeyCode.Space))
        {

            velocity += 50;

        }

        if (direction > 0) {


            facing = 1;

        }

        if (direction > 0)
        {


            facing = -1;

        }

        direction *= 0.9f;

        pos.x += direction * Time.deltaTime;

        pos.y += velocity * Time.deltaTime;

        transform.position = pos;


        bool getHit(Vector2 pos2) {

            return rend.bounds.Contains(pos2);
        
        }
    }
}
