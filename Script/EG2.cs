using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EG2 : MonoBehaviour
{
    public GameObject ghost2;
    float destroyTime = 0f;
    bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        ghost2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(active)
        {
            destroyTime += 1 * Time.deltaTime;
                if (destroyTime > 6)
                {

                    ghost2.SetActive(false);
                }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("HitE"))
        {
            ghost2.SetActive(true);
            active = true;  
        }
    }
}
