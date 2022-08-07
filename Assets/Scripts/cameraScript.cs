using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    public Transform player;
    
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position,Time.deltaTime * 5.0f);
    
       
    }
}