using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    public int speed = 200;
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position += (Vector3)touch.deltaPosition/speed;
            }
        }

        if (Input.touchCount == 2)
        {
            Touch touch = Input.GetTouch(1);

            if (touch.phase == TouchPhase.Began)
            {
                // Halve the size of the cube.
                transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
            }

            if (touch.phase == TouchPhase.Ended)
            {
                // Restore the regular size of the cube.
                transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
        }
    }
}
