using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    AudioSource _audioSource;
    public AudioClip collectSound;
    public static int coins = 0;
    public static int oldAmount = 0;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        // Death if Spike or Enemy
        if(other.CompareTag("Spike"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        // print("enter");
         // Score change if Candy
        if (other.CompareTag("Coin"))
        {
            coins += 1;
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            Destroy(other.gameObject);
        }
    }

}
