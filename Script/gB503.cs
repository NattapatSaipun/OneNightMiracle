using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gB503 : MonoBehaviour
{

    public GameObject ghostA503;
    float destroyTime = 0f;
    public static bool active = false;

   

    // Start is called before the first frame update
    void Start()
    {
        ghostA503.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (active == true)
          {  
            destroyTime += 1 * Time.deltaTime;
            if(destroyTime > 0)
            ghostA503.SetActive(true);
           
            if (ghostA503) 
            {
             
               
                if (destroyTime > 10)
                        {

                    ghostA503.SetActive(false);
                    door1.book = true;
                    active = false;


                }
            }
           
        }
    }
   
}
