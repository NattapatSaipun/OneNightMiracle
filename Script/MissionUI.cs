using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionUI : MonoBehaviour
{
    [Header("Mission")]
    public GameObject mission1;
    public GameObject mission2;
    public GameObject mission3;
    public GameObject mission4;
    public GameObject mission5;

    [Header("Palce")]
    public GameObject palce1;
    public GameObject palce2;
    public GameObject palce3;
    public GameObject palce4;
    public GameObject palce5;

    [Header("KeysItem")]
    public GameObject key1;
    public GameObject key2;
    public GameObject key3;
    public GameObject key4;
   


    // Start is called before the first frame update
    void Start()
    {
        Mission1();


    }

    // Update is called once per frame
    void Update()
    {
       if(key1 == null) 
        {
            Mission2();
        }
       if(key2 == null)
        {
            Mission3();
        }
       if(key3 == null)
        {
            Mission4();
        }
       if(key4 == null)
        {
            Mission5();
        }
    }

    public void Mission1()
    {
        mission1.gameObject.SetActive(true);
        mission2.gameObject.SetActive(false);
        mission3.gameObject.SetActive(false);
        mission4.gameObject.SetActive(false);
        mission5.gameObject.SetActive(false);

        palce1.gameObject.SetActive(true);
        palce2.gameObject.SetActive(false);
        palce3.gameObject.SetActive(false);
        palce4.gameObject.SetActive(false);
        palce5.gameObject.SetActive(false);
    }
    public void Mission2()
    {
        mission1.gameObject.SetActive(false);
        mission2.gameObject.SetActive(true);
        mission3.gameObject.SetActive(false);
        mission4.gameObject.SetActive(false);
        mission5.gameObject.SetActive(false);

        palce1.gameObject.SetActive(false);
        palce2.gameObject.SetActive(true);
        palce3.gameObject.SetActive(false);
        palce4.gameObject.SetActive(false);
        palce5.gameObject.SetActive(false);
    }
    public void Mission3()
    {
        mission1.gameObject.SetActive(false);
        mission2.gameObject.SetActive(false);
        mission3.gameObject.SetActive(true);
        mission4.gameObject.SetActive(false);
        mission5.gameObject.SetActive(false);

        palce1.gameObject.SetActive(false);
        palce2.gameObject.SetActive(false);
        palce3.gameObject.SetActive(true);
        palce4.gameObject.SetActive(false);
        palce5.gameObject.SetActive(false);
    }

    public void Mission4()
    {
        mission1.gameObject.SetActive(false);
        mission2.gameObject.SetActive(false);
        mission3.gameObject.SetActive(false);
        mission4.gameObject.SetActive(true);
        mission5.gameObject.SetActive(false);

        palce1.gameObject.SetActive(false);
        palce2.gameObject.SetActive(false);
        palce3.gameObject.SetActive(false);
        palce4.gameObject.SetActive(true);
        palce5.gameObject.SetActive(false);
    }
    public void Mission5()
    {
        mission1.gameObject.SetActive(false);
        mission2.gameObject.SetActive(false);
        mission3.gameObject.SetActive(false);
        mission4.gameObject.SetActive(false);
        mission5.gameObject.SetActive(true);

        palce1.gameObject.SetActive(false);
        palce2.gameObject.SetActive(false);
        palce3.gameObject.SetActive(false);
        palce4.gameObject.SetActive(false);
        palce5.gameObject.SetActive(true);
    }
}
