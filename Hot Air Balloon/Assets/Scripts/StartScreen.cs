using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject Text, Button1, Button2;
    public GameObject creditText1, creditText2, creditText3, creditText4, creditButton;
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void CreditButton()
    {
        Text.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
        creditText1.SetActive(true);
        creditText2.SetActive(true);
        creditText3.SetActive(true);
        creditText4.SetActive(true);
        creditButton.SetActive(true);
    }

    public void BackButton()
    {
        Text.SetActive(true);
        Button1.SetActive(true);
        Button2.SetActive(true);
        creditText1.SetActive(false);
        creditText2.SetActive(false);
        creditText3.SetActive(false);
        creditText4.SetActive(false);
        creditButton.SetActive(false);
    }
}
