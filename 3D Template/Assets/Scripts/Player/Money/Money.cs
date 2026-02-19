using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class Money : MonoBehaviour
{
    /// <summary>
    /// This script will handle the money that the player has.
    /// </summary>
    [Header("Int")]
    public int currentMoney;
    public int maxMoney;

    [Header("TMP")]
    public TextMeshProUGUI moneyText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = "Money: " + currentMoney.ToString() + "/" + maxMoney.ToString();
    }
}
