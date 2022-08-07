using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class gameManager : MonoBehaviour
{
    public GameObject theMusic;
    public bool startPlaying;
    public beatScroller bs;
    public static gameManager instance;
    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerfectNote = 150;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI lastScoreText;
    public float zaman;
    public GameObject countdownCanvas;

    void Start()
    {
        instance = this;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (zaman >= 3)
        {

            theMusic.SetActive(true);
            Destroy(countdownCanvas);

            if (!startPlaying)
            {
                if (Input.anyKeyDown)
                {
                    startPlaying = true;
                    bs.hasStarted = true;


                }

            }
        }
        zaman += Time.deltaTime;
        if (currentScore < 0)
        {
            currentScore = 0;
        }
        scoreText.text = "Score: " + currentScore.ToString();
        lastScoreText.text = "Score: " + currentScore.ToString();

    }
    public void noteHit()
    {

        //Score(scorePerNote * currentMultiplier);
        lastScoreText.text = "Score: " + currentScore.ToString();


    }
    public void normalHit()
    {
        sliderController.sliderInstance.healthChanger(1);
        Score(scorePerNote);
        noteHit();

    }
    public void goodHit()
    {
        sliderController.sliderInstance.healthChanger(1);
        Score(scorePerGoodNote);
        noteHit();

    }
    public void perfectHit()
    {
        sliderController.sliderInstance.healthChanger(1);
        Score(scorePerGoodNote);
        noteHit();

    }
    public void noteMissed()
    {
        sliderController.sliderInstance.healthChanger(-1);

        Score(-100);

    }
    public void Score(int score)
    {
        currentScore += score;



    }
}

