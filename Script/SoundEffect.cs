using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public GameObject effect;
    bool active = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!active)
        {
           effect.SetActive(true);
            active = true;
        }
       
    }

}
