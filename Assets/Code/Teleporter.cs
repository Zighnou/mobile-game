using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private Transform destination;
    // Start is called before the first frame update
    public bool setDest;
    void Start()
    {
        if(setDest == false) 
        {
            destination = GameObject.FindGameObjectWithTag("enter").GetComponent<Transform>();
        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("exit").GetComponent<Transform>();
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        other.transform.position = new Vector2(destination.position.x, destination.position.y);
    }

}
