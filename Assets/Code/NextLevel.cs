using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string levelToLoad = "Level1";


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(levelToLoad);
            SwipeCount.swipeAmount = 0;
            Collectable.oldAmount = Collectable.coins;
        }

    }
}
