using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5);
    }
}
