using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    //All file Datas:
    private GameObject[] Datas;
    
    //Info of Player:
    public int life = 3;

    //Current Quiz/Scene:
    public int scene;
    public string nameQuiz;
    public int maxScore;



    public void Awake()
    {
        //Check DATA files and if more than 1, destroy extra DATA files:
        Datas = GameObject.FindGameObjectsWithTag("DATA");
        if(Datas.Length >= 2) //verifica se tem mais de 1 DATA na cena
        {
            Destroy (Datas[0]); //eliminar DATA antiga
        }
        DontDestroyOnLoad (transform.gameObject);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
