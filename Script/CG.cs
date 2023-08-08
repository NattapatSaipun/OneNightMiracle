using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CG : MonoBehaviour
{
    public GameObject ghost;

    public static bool active,spone;
    public GameObject fd;

    float destroyTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spone = false;
        ghost.SetActive(false);
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(fd)
        {
            spone=true;
        }
        if (fd.gameObject == null && spone)
        {
            ghost.SetActive(true);
            active = true;
            destroyTime += 1 * Time.deltaTime;
            if (destroyTime > 15)
            {

                ghost.SetActive(false);
            }
        }
    }
}
