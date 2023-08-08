using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public Button start;
    public void NextScene()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
    public void ExitScene()
    {
        Application.Quit();
    }
}
