using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    [SerializeField] private Text _text;
    
    public void UpdateUI(float nrOfLives)
    {
        _text.text = "Player Lives: " + nrOfLives;
    }
}
