using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SwipeCount : MonoBehaviour
{
    public TextMeshProUGUI swipeCounter;
    public static int swipeAmount = 0;
    // Start is called before the first frame update

    // Update is called once per frame

    void Update()
    {
        swipeCounter.text = SwipeCount.swipeAmount.ToString("0");
    }
}
