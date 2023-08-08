using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpscare : MonoBehaviour
{
    public AudioSource scream;
    

    public GameObject player;
    public GameObject jumpscare;
    public GameObject black;
    public GameObject gameover;
    public GameObject gameover1;

    float darkTime = 0f;
    bool active;
    




    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        { 
       darkTime += 1 * Time.deltaTime;

            black.SetActive(true);
            scream.Play();

        }
        if (darkTime > 5f)
        {
            scream.gameObject.SetActive(true);
            
            jumpscare.SetActive(true);
            player.SetActive(false);
             black.SetActive(false);
                   

            if (darkTime > 7f)
            {
                gameover.SetActive(true);
                if(darkTime > 10f)
                {
                    gameover.SetActive(false);
                     gameover1.SetActive(true);
                    scream.gameObject.SetActive(false);
                   
                   
                }

                if (darkTime > 13f)
                { 
                    SceneManager.LoadScene(1);
                }
               
            }
        }
         if(jumpscare.activeSelf)
        {
           
        }

    }

    private void OnTriggerEnter(Collider other)
    {
       

            black.SetActive(true);
                scream.Play();
       
        active = true;
        




    }
    private void OnTriggerExit(Collider other)
    {
        black.SetActive(false);
        scream.Stop();
        active = false; 
        darkTime = 0f;
    }
}
