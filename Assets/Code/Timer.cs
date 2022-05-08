using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI level1Time;
    public TextMeshProUGUI level2Time;
    public TextMeshProUGUI level3Time;
    public TextMeshProUGUI level4Time;
    public TextMeshProUGUI level5Time;
    bool timerStarted = false;
    
    void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            timerStarted = true;
        }
        if(timerStarted)
        {
            timeRemaining += Time.deltaTime;
        }
        
        DisplayTime(timeRemaining);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay <= 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeRemaining % 60);

        if (SceneManager.GetActiveScene().name == "Level1") {
            PlayerPrefs.SetString("level1Min", minutes.ToString());
            PlayerPrefs.SetString("level1Sec", seconds.ToString());
        }

        else if (SceneManager.GetActiveScene().name == "Level2") {
            PlayerPrefs.SetString("level2Min", minutes.ToString());
            PlayerPrefs.SetString("level2Sec", seconds.ToString());
        }

        else if (SceneManager.GetActiveScene().name == "Level3") {
            PlayerPrefs.SetString("level3Min", minutes.ToString());
            PlayerPrefs.SetString("level3Sec", seconds.ToString());
        }

        else if (SceneManager.GetActiveScene().name == "Level4") {
            PlayerPrefs.SetString("level4Min", minutes.ToString());
            PlayerPrefs.SetString("level4Sec", seconds.ToString());
        }

        else if (SceneManager.GetActiveScene().name == "Level5") {
            PlayerPrefs.SetString("level5Min", minutes.ToString());
            PlayerPrefs.SetString("level5Sec", seconds.ToString());
        }

        else if (SceneManager.GetActiveScene().name == "EndScene") {
            level1Time.text = PlayerPrefs.GetString("level1Min") + " min " + PlayerPrefs.GetString("level1Sec") + " sec";
            level2Time.text = PlayerPrefs.GetString("level2Min") + " min " + PlayerPrefs.GetString("level2Sec") + " sec";
            level3Time.text = PlayerPrefs.GetString("level3Min") + " min " + PlayerPrefs.GetString("level3Sec") + " sec";
            level4Time.text = PlayerPrefs.GetString("level4Min") + " min " + PlayerPrefs.GetString("level4Sec") + " sec";
            level5Time.text = PlayerPrefs.GetString("level5Min") + " min " + PlayerPrefs.GetString("level5Sec") + " sec";
        }
        
        timerText.text = timeRemaining.ToString("0");
    }
}