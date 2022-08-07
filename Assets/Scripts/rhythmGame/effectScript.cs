using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectScript : MonoBehaviour
{
    public float lifeTime=1f;
    void Start()
    {
        
    }

    
    void Update()
    {
            Destroy(gameObject,lifeTime);
    }
}
