using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class coins_counter : MonoBehaviour
{
    public TMP_Text coinsText;
    public int collected_coins;

    private void Update()
    {
        coinsText.text = "Монет собрано: " + collected_coins;
    }
}
