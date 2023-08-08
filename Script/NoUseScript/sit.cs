using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sit : MonoBehaviour
{
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            StartSit();
            if (Input.GetKeyDown(KeyCode.W)) 
            {
                Camera.GetComponent<Animator>().Play("sitAndWalk");
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            StopSit();
        }
    }
    void StartSit()
    {
        Camera.GetComponent<Animator>().Play("sit");
       
    }
    void StopSit()
    {
        Camera.GetComponent<Animator>().Play("New State");
    }
}
