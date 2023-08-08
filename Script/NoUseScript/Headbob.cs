﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headbob : MonoBehaviour
{
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {

            StartBobbing();
        } 
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartBobbing();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            StartBobbing();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            StartBobbing();
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            StopBobbing();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            StopBobbing();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            StopBobbing();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            StopBobbing();
        }
    }

    void StartBobbing()
    {
        Camera.GetComponent<Animator>().Play("HeadBobby");
    }
    void StopBobbing()
    {
        Camera.GetComponent<Animator>().Play("New State");
    }
    
    
    
   
}