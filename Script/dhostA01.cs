using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dhostA01 : MonoBehaviour
{
    public GameObject ghostA01;
    float destroyTime = 0f;
    bool active = false;
    public AudioSource effect;
   
    // Start is called before the first frame update
    void Start()
    {
        ghostA01.SetActive(false);
        
    }
    
    // Update is called once per frame
    void Update()
    {
        if (active==true) 
        { 
        destroyTime += 1 * Time.deltaTime;
        if (destroyTime > 3)
        {

                ghostA01.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter(Collider target)
    {
        if(target.gameObject.tag.Equals("Hitbox"))
        {
            
            
            ghostA01.SetActive(true);
            active = true;
            effect.Play();
          
        } 
      
    }
}
