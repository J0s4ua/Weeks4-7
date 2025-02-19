using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepos.z = 0;
        Vector3 direction = mousepos - transform.position;
        Vector3 pos = mousepos - transform.position;

        transform.up += direction;
        transform.up += pos;
        
    }
}
