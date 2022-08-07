using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sliderController : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;
    public Slider slider;
    public static sliderController sliderInstance;
    public AudioSource song;
    public GameObject gameOver;
    void Start()
    {
        sliderInstance = this;
        currentHealth = maxHealth;
        slider.value = maxHealth;

    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth <= 0)
        {
            StartCoroutine(menuyuGetir());
        }

    }
    public void healthChanger(int damage)
    {
        currentHealth += damage;
        slider.value = currentHealth;

    }
    IEnumerator menuyuGetir()
    {
        gameOver.SetActive(true);
        song.Stop();
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");

    }
}
