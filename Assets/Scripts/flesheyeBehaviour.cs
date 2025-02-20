using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class flesheyeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 pos2 = player.transform.position;
        Vector3 direction = transform.eulerAngles;

        direction.z = (pos.x * pos.y) - (pos2.x * pos2.y);

        transform.up = direction;

        pos.x += 0.5f * Time.deltaTime;

        transform.position = pos;

        



    }
}
