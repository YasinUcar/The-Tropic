using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class beatScroller : MonoBehaviour
{
   
    public float beatTempo;
    public bool hasStarted;
    beatScroller theBs;
   

    void Start()
    {

        beatTempo = beatTempo / 60;//one beat 120 bmp second = 60
        theBs = GetComponent<beatScroller>();
    }

    void Update()
    {
      
        if (gameManager.instance.zaman >= 7)
        {

            if (!hasStarted)
            {
                if (Input.anyKey)
                    hasStarted = true;
            }
            else
            {
                transform.position -= new Vector3(0, beatTempo * Time.deltaTime, 0);
            }

        }
    }


}
