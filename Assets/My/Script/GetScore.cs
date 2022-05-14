using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    //Variables:
    public Gameplay gameplay;
    public Text scoreTXT;

    void Start()
    {
        gameplay = GameObject.Find("Player").GetComponent<Gameplay>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTXT.text = string.Format("{0}p", gameplay.score);
    }
}
