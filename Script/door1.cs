using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door1 : MonoBehaviour
{
    public float radius = 3f;
    public Transform player;
    public Transform interactItem;
    bool hasIneract = false,door = false,notes=false;
    public Text text;
    public Text needKey;

    public GameObject note;

    public static bool doorKey = false,book = true;
   
    

    // Start is called before the first frame update
    void Start()
    {
        
        interactItem.GetComponent<Animator>().Play("New State");
        text.enabled = false;
        needKey.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
       
        

        float distance = Vector3.Distance(player.position, interactItem.position);
        if (  distance <= radius && !hasIneract && book)
        {          
            if (doorKey) 
            {
                text.enabled = true;
                needKey.enabled = false;
                if (Input.GetKeyDown(KeyCode.E))
                    {
                        text.enabled = false;
                        hasIneract = true;
                        interactItem.GetComponent<Animator>().Play("DoorOpen");
                        door = true;
                        book = false;

                    }
            }
            else
            {
                needKey.enabled = true;
            }
        }
        else
        {
            text.enabled = false;
            needKey.enabled = false;
        }
           


        if ((distance >= radius && hasIneract))
        {
            text.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {

                interactItem.GetComponent<Animator>().Play("DoorClose");
                hasIneract = false;
                door = false;
            }
           
        }
        if ((distance >= radius+1 && hasIneract))
        {
            text.enabled = false;
            hasIneract = false;
            
        }
        if (door == true && distance <= radius+1 && !hasIneract)
            {
            text.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
                {
                    text.enabled = false;
                    interactItem.GetComponent<Animator>().Play("DoorClose");
                    door = false;
                }

        }
         if (note == null&& !notes)
        {
          text.enabled = false;
          interactItem.GetComponent<Animator>().Play("DoorClose");
          door = false;
           notes = true;
        }

    }

    

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactItem.position, radius);
    }
}
