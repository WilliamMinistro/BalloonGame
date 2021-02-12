using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTracker : MonoBehaviour
{
    void Update()
    {
        if(RandomGenerator.pointCount > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", RandomGenerator.pointCount);
        }
    }
}
