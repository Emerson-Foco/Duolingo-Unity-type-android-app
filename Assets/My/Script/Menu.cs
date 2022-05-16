using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
    //Variables:
    public GameObject menuBar;
    public GameObject store;
    public GameObject credits;
    
    //Functions:
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void DeleteSave()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }

    public void MenuBar()
    {
        if(menuBar.gameObject.activeSelf)
        {
            menuBar.SetActive(false);
        }
        else
        {
            menuBar.SetActive(true);
        }
    }

    public void MenuInit()
    {
        //Deactivate others:
        store.SetActive(false);
        credits.SetActive(false);
        MenuBar();
    }

    public void Store()
    {
        store.SetActive(true);
        MenuBar();
        
        //Deactivate others:
        credits.SetActive(false);
    }

    public void Credits()
    {
        credits.SetActive(true);
        MenuBar();

        //Deactivate others:
        store.SetActive(false);
    }
}
