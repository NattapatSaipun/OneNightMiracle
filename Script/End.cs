using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class End : MonoBehaviour
{
    public AudioSource scream;


    public GameObject player;
    public GameObject jumpscare;
    public GameObject black;
    public GameObject gameover;
    public GameObject gameover1;

    public GameObject box;
    float darkTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(box == null)
        {
            black.SetActive(true);
            darkTime += 1 * Time.deltaTime;
            if (darkTime > 5f)
            {
                scream.gameObject.SetActive(true);

                jumpscare.SetActive(true);
                player.SetActive(false);
                black.SetActive(false);


                if (darkTime > 7f)
                {
                    gameover.SetActive(true);
                    if (darkTime > 10f)
                    {
                        gameover.SetActive(false);
                        gameover1.SetActive(true);
                        scream.gameObject.SetActive(false);


                    }

                    if (darkTime > 13f)
                    {
                        SceneManager.LoadScene(1);
                    }

                }
            }
        }
    }
}
