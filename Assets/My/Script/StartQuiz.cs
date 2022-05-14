using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartQuiz : MonoBehaviour
{
    //Variables:
    public int scene = 0;
    public string nameQuiz;
    public Text nameTXT;

    public int maxScore;
    public Text maxScoreTXT;

    //GameData for saves/Load;
    public GameData gameData;

    //LVL:
    public LVL lvl;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey(nameQuiz))
        {
            maxScore = PlayerPrefs.GetInt(nameQuiz);
        }
        else
        {
            maxScore = 0;
        }

        gameData = GameObject.Find("GameData").GetComponent<GameData>();  


        //Name TXT:
        nameTXT.text = string.Format(nameQuiz);

        //Max Score TXT:
        maxScoreTXT.text = string.Format("{0}p", maxScore);

        //Calculating LVL:
        lvl = GameObject.Find("LVL").GetComponent<LVL>();
        lvl.progressCount = lvl.progressCount + maxScore;

    }

    // Update is called once per frame
    void Update()
    {
        gameData = GameObject.Find("GameData").GetComponent<GameData>();
    }

    public void LoadLVL()
    {
        gameData.scene = scene;
        gameData.nameQuiz = nameQuiz;
        gameData.maxScore = maxScore;

        SceneManager.LoadScene(scene);
    }
}
