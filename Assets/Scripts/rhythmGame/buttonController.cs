using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{
    private SpriteRenderer sp;
    public Sprite defaultImage;
    public Sprite pressedımage;
    public KeyCode keytoPress;
    void Start()
    {
        sp  =GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if(Input.GetKeyDown(keytoPress))
        {
            sp.sprite=pressedımage;
        }
        if(Input.GetKeyUp(keytoPress))
        {
            sp.sprite=defaultImage;
        }
    }
}
