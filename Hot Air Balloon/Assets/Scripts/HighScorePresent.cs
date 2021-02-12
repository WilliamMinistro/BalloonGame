using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScorePresent : MonoBehaviour
{
    public Text Highest;
    void Start()
    {
        Highest.text = "HIGHSCORE: " + PlayerPrefs.GetInt("HighScore");
    }
}
