using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Eghost : MonoBehaviour
{
    public static GameObject ghost;
    
    public Transform player1;
    public static bool active;

    


    // Start is called before the first frame update
    void Start()
    {
       
        ghost.SetActive(false);
        active = false;


    }
    private void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("HitE"))
        {
            if(active)
            ghost.SetActive(false);
        }
    }


}
