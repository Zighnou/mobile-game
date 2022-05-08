using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NonLevelFunctions : MonoBehaviour
{
    public void titleScreen(){
        SceneManager.LoadScene("StartScene");
        Collectable.coins = 0;
        SwipeCount.swipeAmount = 0;
        Collectable.coins = 0;
        PlayerPrefs.SetString("level1Min", "0");
        PlayerPrefs.SetString("level1Sec", "0");
        PlayerPrefs.SetString("level2Min", "0");
        PlayerPrefs.SetString("level2Sec", "0");
        PlayerPrefs.SetString("level3Min", "0");
        PlayerPrefs.SetString("level3Sec", "0");
        PlayerPrefs.SetString("level4Min", "0");
        PlayerPrefs.SetString("level4Sec", "0");
        PlayerPrefs.SetString("level5Min", "0");
        PlayerPrefs.SetString("level5Sec", "0");
    }

    public void loadGame(){
        SceneManager.LoadScene("StoryScene");
    }

    public void levelSelect(){
        SceneManager.LoadScene("Menu");
    }

    public void loadLevel1(){
        SceneManager.LoadScene("Level1");
        Collectable.oldAmount = Collectable.coins;
    }

    public void loadLevel2(){
        SceneManager.LoadScene("Level2");
        Collectable.oldAmount = Collectable.coins;
    }

    public void loadLevel3(){
        SceneManager.LoadScene("Level3");
        Collectable.oldAmount = Collectable.coins;
    }

    public void loadLevel4(){
        SceneManager.LoadScene("Level4");
        Collectable.oldAmount = Collectable.coins;
    }

    public void loadLevel5(){
        SceneManager.LoadScene("Level5");
        Collectable.oldAmount = Collectable.coins;
    }

    public void exitGame(){
        Application.Quit();
    }

    public void restartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SwipeCount.swipeAmount = 0;
        Collectable.coins = Collectable.oldAmount;
    }
}
