using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Teleporter : MonoBehaviour
{
    public GameObject destination;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player")) {
            other.transform.position = new Vector2(destination.transform.position.x,destination.transform.position.y);
        }
    }

}
