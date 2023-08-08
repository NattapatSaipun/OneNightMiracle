using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostESound : MonoBehaviour
{
    public AudioSource ghostSound;
    public GameObject g1;
    

    Vector3 lastPos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
       
            crawl();
 

    }

    

    void crawl()
    {
        if (lastPos != g1.gameObject.transform.position)
        {
            ghostSound.GetComponent<AudioSource>().Play();
            g1.GetComponent<Animator>().Play("New State");
        }
        lastPos = g1.gameObject.transform.position;
        
    }
}
