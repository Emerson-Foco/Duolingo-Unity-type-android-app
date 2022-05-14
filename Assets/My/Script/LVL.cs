using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LVL : MonoBehaviour
{
    //Variables:
    public Text LVLTXT;
    public int progressCount = 100;
    public int lvl = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lvl = progressCount / 100;
        LVLTXT.text = string.Format("{0}", lvl);
    }
}
