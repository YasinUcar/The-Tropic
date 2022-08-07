using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteObject : MonoBehaviour
{
    public bool canBePressed;
    public KeyCode keyTooPress;
    public GameObject normalEffect, goodEffect, perfectEffect, missEffect;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(keyTooPress))
        {
            if (canBePressed == true)
            {
                gameObject.SetActive(false);

                if (Math.Abs(transform.position.y) > 0.25f)
                {

                    gameManager.instance.normalHit();
                    Instantiate(normalEffect, transform.position, normalEffect.transform.rotation);
                }
                else if (Math.Abs(transform.position.y) > 0.05f)
                {

                    gameManager.instance.goodHit();
                    Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
                }
                else
                {

                    gameManager.instance.perfectHit();
                    Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
                }



            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator" && gameObject.activeSelf)
        {
            canBePressed = false;
            gameManager.instance.noteMissed();
            Instantiate(missEffect, transform.position, missEffect.transform.rotation);
        }
        if (other.tag == "Destroy")
        {

            Destroy(this.gameObject);
        }
    }

}