using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitlePage : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }

}
