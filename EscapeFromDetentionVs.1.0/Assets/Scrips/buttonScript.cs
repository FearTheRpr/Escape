using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    
   
    private float timeRemainingfive = 300;
    private float timeRemainingten = 600;
    private float timeRemainingfifteen = 900;
    public Text timeText;
    public GameManager gameManager;
    public bool countDown = false;
    public bool countDown2 = false;
    public bool countDown3 = false;
    public GameObject resetButton;
    public AudioSource loseMessage;

    public void fiveMinTimer()
    {
        countDown = true;

    }
    public void tenMinuteTimer()
    {
        countDown2 = true;

    }
    public void fifteenMinuteTimer()
    {
        countDown3 = true;

    }

    // Update is called once per frame
    void Update()
    {
        //one a button is pressed at the start, one of these groups will initiate the timer
        if (countDown)
        {
            

            if (timeRemainingfive > 0)
            {
                timeRemainingfive -= Time.deltaTime;
                DisplayTime(timeRemainingfive);
                
            }
            //time limit reached message
            if (timeRemainingfive < 0)
            {
                Debug.Log("Your time has come to an end");
                timeRemainingfive = 0;
                countDown = false;
                loseMessage.Play();
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }
        if (countDown2)
        {

            if (timeRemainingten > 0)
            {
                timeRemainingten -= Time.deltaTime;
                DisplayTime(timeRemainingten);

            }
            //time limit reached message
            if (timeRemainingten < 0)
            {
                Debug.Log("Your time has come to an end");
                timeRemainingten = 0;
                countDown = false;
                loseMessage.Play();
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (countDown3)
        {

            if (timeRemainingfifteen > 0)
            {
                timeRemainingfifteen -= Time.deltaTime;
                DisplayTime(timeRemainingfifteen);

            }
            //time limit reached message
            if (timeRemainingfifteen < 0)
            {
                Debug.Log("Your time has come to an end");
                timeRemainingfifteen = 0;
                countDown = false;
                loseMessage.Play();
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
   
   
    
}
