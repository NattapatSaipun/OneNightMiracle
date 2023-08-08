using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionWaypoint : MonoBehaviour
{

    public Image img;
    public Transform target;
    public Transform target2;
    public Text meter;
    public Text Mis1;
    public Text placeTarget;
   
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float minX = img.GetPixelAdjustedRect().width / 2;
        float maxX = Screen.width - minX;

        float minY = img.GetPixelAdjustedRect().height / 2;
        float maxY = Screen.width - minY;

        Vector2 pos = Camera.main.WorldToScreenPoint(target.position);

        if (Vector3.Dot((target.position - transform.position), transform.forward) < 0)
        {
            //Target is behind Player
            if (pos.x < Screen.width / 2)
            {
                pos.x = maxX;
            }
            else
            {
                pos.x = minY;
            }
        }


        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        img.transform.position = pos;

        // text
        meter.text = ((int)Vector3.Distance(target.position, transform.position)).ToString() + "m";
       if((int)Vector3.Distance(target.position, transform.position) <= 5)
        {
             img.enabled = false;
             meter.enabled = false;
            if (Input.GetKeyDown(KeyCode.E) && (int)Vector3.Distance(target.position, transform.position) <= 1) 
            { 
              target.position = target2.position;
                Mis1.text = "Mission2";
                placeTarget.text = "B503";
            }
        }
       else
        {
            img.enabled = true;
            meter.enabled = true;
        }

    }
}
