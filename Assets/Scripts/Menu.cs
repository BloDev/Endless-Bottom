using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Menu : MonoBehaviour 
{
    public TMP_Text highScoreText;

    void Start() { 
        highScoreText.SetText("High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString());
    }

    public void Play() {
        FindObjectOfType<AudioManager>().Play("Background Music");
        FindObjectOfType<AudioManager>().Play("Button Clicking Sound");
        SceneManager.LoadScene(1);
    }

    public void Quit() {
        FindObjectOfType<AudioManager>().Play("Button Clicking Sound");
        Application.Quit();
    }
}
