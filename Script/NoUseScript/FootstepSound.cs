using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioSource AudioSource;
   

    //public AudioClip footstep;
    // Start is called before the first frame update
    void Start()
    {
         AudioSource.GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Footstep();
    }
    private  void Footstep() 
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            AudioSource.Play();
        }   
        if (Input.GetKeyUp(KeyCode.W))
        {
            AudioSource.Stop();

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            AudioSource.Play();
        } 
        if (Input.GetKeyUp(KeyCode.A))
        {
            AudioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AudioSource.Play();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            AudioSource.Stop();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            AudioSource.Play();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            AudioSource.Stop();
        }
    }
 
}
