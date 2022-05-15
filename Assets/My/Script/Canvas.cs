using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    //Effects
    public GameObject effect_correct;
    public Transform ui;
    //public GameObject position;

    public void EffecCorrect()
    {
        //effect:
        GameObject effectCorrect = Instantiate(effect_correct, ui.position, ui.rotation);
        effectCorrect.transform.parent = this.transform;
        Destroy(effectCorrect.gameObject, 2);
    }
}
