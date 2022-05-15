using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    //Variables:
    public int score = 0;
    public int life = 4;
    public GameObject[] questions;
    public int questionsCont = 0;
    public int questionsMax;

    //Control of painels:
    public Painels painels;

    //Control of time:
    public Text timeTXT;
    public float startTime = 180;
    public float time;

    //Data:
    public GameData gameData;

    //Canvas (UI):
    public Canvas ui;

    
    // Start is called before the first frame update
    void Start()
    {
        //Getting GameData:
        gameData = GameObject.Find("GameData").GetComponent<GameData>();


        questions = GameObject.FindGameObjectsWithTag("Question");
        questionsMax = questions.Length - 1; //Initializing in 0*

        //Deactivating all future questions
        for(int i = 1; i <= questionsMax; i++)
        {
            questions[i].gameObject.SetActive(false);
        }

        Time.timeScale = 1;

        painels = GameObject.Find("Painels").GetComponent<Painels>();

        //Taking time txt:
        timeTXT = GameObject.Find("Time_TXT").GetComponent<Text>();
        time = startTime;

        //Taking UI scrip:
        ui = GameObject.Find("UI").GetComponent<Canvas>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //Control of time:
        time -= Time.deltaTime;
        int minutes = (int)(time / 60); //pegar valor da divisão (minutos)
        int seconds = (int)(time % 60); //pegar resto da divisão (segundos)
        timeTXT.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        //Time condition:
        if(time <= 0)
        {
            Lost();
        }

    }

    //Next question:
    public void NextQuestion()
    {
        //Effect:
        ui.EffecCorrect();

        //Score
        questions[questionsCont].gameObject.SetActive(false);
        questionsCont++;
        score = score + 10;
        if(questionsCont <= questionsMax)
        {
            questions[questionsCont].gameObject.SetActive(true);
            time = startTime;
        }
        else
        {
            //Active painel WIN
            painels.Win();

            if(score > gameData.maxScore)
            {
                PlayerPrefs.SetInt(gameData.nameQuiz, score);
            }
        }
    }

    public void SkipQuestion()
    {
        questions[questionsCont].gameObject.SetActive(false);
        questionsCont++;
        score = score + 0;
        if(questionsCont <= questionsMax)
        {
            questions[questionsCont].gameObject.SetActive(true);
            time = startTime;
        }
        else
        {
            //Active painel WIN
            painels.Win();

            if(score > gameData.maxScore)
            {
                PlayerPrefs.SetInt(gameData.nameQuiz, score);
            }
        }
    }

    //Lost:
    public void Lost()
    {
        painels.Lost();
            
        if(score > gameData.maxScore)
        {
            PlayerPrefs.SetInt(gameData.nameQuiz, score);
        }
    }

}
