using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {    
        if(other.CompareTag("GreenGem"))
        {
            Destroy(gameObject);
            Score.score += 10;
        }

        if(other.CompareTag("BlueGem"))
        {
            Destroy(gameObject);
            Score.score += 40;
        }
    }
}
