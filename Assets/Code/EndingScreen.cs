using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScreen : MonoBehaviour
{
    public void titleScreen(){
        SceneManager.LoadScene("Title");
    }

    public void exitGame(){
        Application.Quit();
    }
}
