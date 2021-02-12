using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void RestartButton()
    {
        HealthController.Health = 100;
        HealthController.Health = 100;
        HealthController.happened = false;
        PauseScript.isPaused = false;
        SceneManager.LoadScene("Game");
        HealthController.Health = 100;
        HealthController.Health = 100;

    }
    public void MenuButton()
    {
        PauseScript.isPaused = false;
        HealthController.happened = false;
        SceneManager.LoadScene("Menu");
        HealthController.Health = 100;
    }
}
