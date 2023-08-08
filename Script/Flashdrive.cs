using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashdrive : MonoBehaviour
{
    public GameObject flashdrive;
    public GameObject preItem;
    public GameObject pressE;

    // Start is called before the first frame update
    void Start()
    {
        flashdrive.SetActive(false);
        pressE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (preItem == null)
        {
            flashdrive.SetActive(true);
            pressE.SetActive(true);
        }
    }
}
