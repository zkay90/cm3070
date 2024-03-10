using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    
    public void displayText()
    {
        gameOverText.alpha = 1.0f;
    }
}
