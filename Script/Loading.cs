using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField] int timeToWait = 5;

    int currentScenceIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentScenceIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentScenceIndex == 3)
        {
            StartCoroutine(WaitforTime());
        }
    }

    IEnumerator WaitforTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene(currentScenceIndex + 1);
    }
    
}
