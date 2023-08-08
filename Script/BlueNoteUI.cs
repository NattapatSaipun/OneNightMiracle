using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueNoteUI : MonoBehaviour
{
    [Header("Note")]
    public GameObject blueNoteUI;
    public Button exit;

    [Header("ChangePage")]
    public Button nextButton;
    public Button backButton;

    [Header("Page")]
    private int page = 1;
    public int pageCount;
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;


    public static BlueNoteUI instance;


    // Start is called before the first frame update
    void Start()
    {
        page1.gameObject.SetActive(true);
        backButton.gameObject.SetActive(false);
        instance = this;
        blueNoteUI.SetActive(!blueNoteUI.activeSelf);
        pageCount = 3 ;
    }
    private void Update()
    {
        //PageCount
       
        if (page == 1) 
        {
            page1.gameObject.SetActive(true);

        }
        else page1.gameObject.SetActive(false);
        if (page == 2)
        {
            page2.gameObject.SetActive(true);

        }
        else page2.gameObject.SetActive(false);
        if (page == 3)
        {
            page3.gameObject.SetActive(true);

        }
        else page3.gameObject.SetActive(false);





        //ButtonSystem
        if (page == pageCount)
        {
            nextButton.gameObject.SetActive(false);
            backButton.gameObject.SetActive(true);
        }
        else nextButton.gameObject.SetActive(true);

        if(page == 1)
        {
            backButton.gameObject.SetActive(false);
            nextButton.gameObject.SetActive(true);
        }
        else
        backButton.gameObject.SetActive(true);
    }
   


    public void Shownote()
    {
        blueNoteUI.SetActive(!blueNoteUI.activeSelf);
    }
    public void ExitButton()
    {
        blueNoteUI.SetActive(!blueNoteUI.activeSelf);
    }
    public void NextButton()
    {
       
        page++;
        
       
    }
    public void BackButton()
    {
       
       page--;
       
    }
}
