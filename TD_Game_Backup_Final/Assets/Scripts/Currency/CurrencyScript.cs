using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class CurrencyScript : MonoBehaviour
{
    public int currentCoins = 0;
    private Text coinTextField;

    private void Update()
    {
        coinTextField.text = "" + currentCoins;
    }

    private void Start()
    {
        coinTextField = gameObject.GetComponent<Text>();
    }

    public void AddCoins(int amount)
    {
        currentCoins += amount;

        coinTextField.text = "" + currentCoins;
    }
}
