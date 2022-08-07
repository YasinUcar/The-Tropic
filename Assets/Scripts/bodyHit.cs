using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyHit : MonoBehaviour
{
    [SerializeField] Collider barikat;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "KaraSimsek")
        {
            sliderController.sliderInstance.healthChanger(-1);
           StartCoroutine(Destroy());
        }
        if(other.gameObject.name=="Final")
        {
            
        }

    }

    IEnumerator Destroy()
    {
        
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }

}

