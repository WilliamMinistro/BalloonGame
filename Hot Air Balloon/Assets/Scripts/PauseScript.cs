using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public AudioSource Song;
    public GameObject canvas;
    public HealthController die;


    public static bool isPaused = false;
    

    public void pauseGame()
    {
        if(isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            scroll_script.speed = 0.05f;
            Song.Play();
            canvas.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            scroll_script.speed = 0;
            Song.Pause();
            canvas.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            scroll_script.speed = 0.05f;
            Song.Play();
            canvas.SetActive(false);
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            scroll_script.speed = 0;
            Song.Pause();
            canvas.SetActive(true);
        }
    }

    public void RestartButton()
    {

        HealthController.happened = false;
        die.die();
        isPaused = true;
        pauseGame();
        SceneManager.LoadScene("Game");

    }
    public void MenuButton()
    {
        isPaused = true;
        pauseGame();
        SceneManager.LoadScene("Menu");
        HealthController.Health = 100;
    }

}
