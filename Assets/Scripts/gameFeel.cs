using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameFeel : MonoBehaviour
{
    float time = 0;
    public Camera mainCam;
      [SerializeField] float SprintFov;
    void Start()
    {
        mainCam = Camera.main;
    }


    void Update()
    {
        time += Time.deltaTime;
      
        if (time > 8f)
        {
            mainCam.fieldOfView = Mathf.Lerp(mainCam.fieldOfView, SprintFov, Time.deltaTime * 2);
        }
    }
}
