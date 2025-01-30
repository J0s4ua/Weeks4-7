using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrettyMuchAnythingThatIsntEnabled : MonoBehaviour


{
    public AudioSource audioSource;
    public AudioClip clip;
    public GameObject go;
    public SpriteRenderer sr;
    public PrettyMuchAnythingThatIsntEnabled script;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {


            sr.enabled = false;
            //script.enabled = false;
            go.SetActive(false);
        
        }

        if (Input.GetKeyDown(KeyCode.Space)) {


            sr.enabled = true;
            //script.enabled = true;
            go.SetActive(true);


        }

        if (Input.GetKey(KeyCode.Space)) {

            audioSource.PlayOneShot(clip);
        
        
        }
    }
}
