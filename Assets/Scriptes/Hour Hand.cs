using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HourHand : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioClip clip1;
    public AudioClip clip2;
    public float speed = 1f;
    public float chimeTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;

        rot.z -= speed * Time.deltaTime;

        if (chimeTime <= rot.z - 15)
        {

            audioSource.PlayOneShot(clip2);
            chimeTime = rot.z;
            
            

        }

        transform.eulerAngles = rot;

        if ((int)rot.z == -180 || (int)rot.z == 180) {

            audioSource.PlayOneShot(clip1);
            print("played sound clip 1");
            

        }
    }
}
