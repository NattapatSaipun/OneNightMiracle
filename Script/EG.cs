using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EG : MonoBehaviour
{
    public  GameObject ghost;
    
    public static bool active;
    public GameObject saizin;

    float destroyTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        ghost.SetActive(false);
        active = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (saizin.gameObject == null)
        {
            ghost.SetActive(true);
            active = true;
            destroyTime += 1 * Time.deltaTime;
            if (destroyTime > 4)
            {

                ghost.SetActive(false);
            }
        }
    }
   
}
