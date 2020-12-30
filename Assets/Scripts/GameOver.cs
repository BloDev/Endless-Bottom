using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour 
{
    public TMP_Text highScoreText;
    public TMP_Text currentScoreText;

    void Start() { 
        highScoreText.SetText("High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString());
        currentScoreText.SetText("Current Score: " + PlayerPrefs.GetInt("Score", 0).ToString());
    }

    public void Restart() {
        SceneManager.LoadScene(1);
    }

    public void Quit() {
        Application.Quit();
    }
}
