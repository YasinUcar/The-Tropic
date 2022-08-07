using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject leftArrow, rightArrow, upArrow, downArrow;


    Rigidbody2D rig;
    void Start()
    {
        
            StartCoroutine(spawnerLeft());
            StartCoroutine(spawnerRight());
            StartCoroutine(spawnerDown());
            StartCoroutine(spawnerUp());
       

    }


    IEnumerator spawnerLeft()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(-1f, Random.Range(9.74f, 14.83f), 19799.41f);
            Instantiate(leftArrow, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
        }

    }

    IEnumerator spawnerRight()
    {

        while (true)
        {
            Vector3 spawnPosition = new Vector3(2f, Random.Range(9.74f, 14.83f), 19799.41f);
            Instantiate(rightArrow, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
        }

    }
    IEnumerator spawnerUp()
    {

        while (true)
        {
            Vector3 spawnPosition = new Vector3(-0.05f, Random.Range(9.74f, 14.83f), 19799.41f);
            Instantiate(upArrow, spawnPosition, upArrow.transform.rotation);
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
        }

    }
    IEnumerator spawnerDown()
    {

        while (true)
        {
            Vector3 spawnPosition = new Vector3(1f, Random.Range(9.74f, 14.83f), 19799.41f);
            Instantiate(downArrow, spawnPosition, downArrow.transform.rotation);
            yield return new WaitForSeconds(Random.Range(1.0f, 5.0f));
        }

    }
}
