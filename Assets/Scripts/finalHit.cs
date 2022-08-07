using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class finalHit : MonoBehaviour
{

    public GameObject oyunSonuCanvas;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "KaraSimsek")
        {
            oyunSonuCanvas.SetActive(true);
            Time.timeScale = 0;

        }


    }
    public void Update()
    {
        if (oyunSonuCanvas.active == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene("Game");
        }
    }



}

