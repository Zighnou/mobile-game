using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinCounter;
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        coinCounter.text = Collectable.coins.ToString("0");
    }
}
