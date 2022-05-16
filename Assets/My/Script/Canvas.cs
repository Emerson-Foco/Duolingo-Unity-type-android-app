using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    //Effects
    public GameObject effect_correct;
    public GameObject effect_error;
    public GameObject effect_skip;
    public Transform ui;
    //public GameObject position;

    public void EffectCorrect()
    {
        //effect:
        GameObject effect = Instantiate(effect_correct, ui.position, ui.rotation);
        effect.transform.parent = this.transform;
        Destroy(effect.gameObject, 2);
    }

    public void EffectError()
    {
        //effect:
        GameObject effect = Instantiate(effect_error, ui.position, ui.rotation);
        effect.transform.parent = this.transform;
        Destroy(effect.gameObject, 2);
    }

    public void EffectSkip()
    {
        //effect:
        GameObject effect = Instantiate(effect_skip, ui.position, ui.rotation);
        effect.transform.parent = this.transform;
        Destroy(effect.gameObject, 2);
    }
}
