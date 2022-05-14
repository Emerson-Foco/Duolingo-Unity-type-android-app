using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    //Variables:
    public bool rightAnswer = false;
    public Gameplay gameplay;
    //public Painels painels;

    public void AnswerTouch()
    {
        if (rightAnswer == true)
        {
            print("true");
            gameplay = GameObject.Find("Player").GetComponent<Gameplay>();
            gameplay.NextQuestion();
        }
        else
        {
            print("false");
            //painels = GameObject.Find("Painels").GetComponent<Painels>();
            gameplay = GameObject.Find("Player").GetComponent<Gameplay>();
            gameplay.Lost();
        }
    }
}
