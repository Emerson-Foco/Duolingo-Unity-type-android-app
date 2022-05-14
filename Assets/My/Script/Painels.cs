using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Painels : MonoBehaviour
{
    //Variables:
    public GameObject panelPause;
    public GameObject panelLost;

    public GameObject panelWin;
    public GameData data;

    
    // Start is called before the first frame update
    void Start()
    {
        panelPause = GameObject.Find("PanelPause");
        panelPause.SetActive(false);

        panelLost = GameObject.Find("PanelLost");
        panelLost.SetActive(false);

        panelWin = GameObject.Find("PanelWin");
        panelWin.SetActive(false);

        data = GameObject.Find("GameData").GetComponent<GameData>();
    }

    // Update is called once per frame
    void Update()
    {
        if(panelPause.gameObject.activeSelf)
        {
            Time.timeScale = 0;
        }
        else if(panelLost.gameObject.activeSelf)
        {
            Time.timeScale = 0;
        }
        else if(panelWin.gameObject.activeSelf)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    //Functions for Painels:
    public void Pause()
    {
        if(panelPause.gameObject.activeSelf)
        {
            panelPause.SetActive(false);
        }
        else
        {
            panelPause.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(data.scene);
    }

    public void InitialMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Lost()
    {
        panelLost.SetActive(true);
    }

    public void Win()
    {
        panelWin.SetActive(true);
    }
}
