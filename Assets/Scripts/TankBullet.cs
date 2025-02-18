using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBullet : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x = 0 + speed;
        speed += 1 * Time.deltaTime;

        transform.position = pos;

        if (speed > 10) {

            Destroy(gameObject);

        }
        


    }
}
