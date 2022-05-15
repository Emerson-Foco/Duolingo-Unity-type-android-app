using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help : MonoBehaviour
{
    //Variables:
    public bool rightAnswer = true;
    public Gameplay gameplay;
    public int cont = 0;
    public int contLimit = 2;
    public GameObject[] iconHelp;

    public void Help()
    {
        if(cont <= contLimit)
        {
            print("true");
            gameplay = GameObject.Find("Player").GetComponent<Gameplay>();
            gameplay.score = gameplay.score - 10;
            
            iconHelp[cont].gameObject.SetActive(false);
            cont++;

            gameplay.NextQuestion();
        }
    }
}
