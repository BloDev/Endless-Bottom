using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Main : MonoBehaviour 
{
    public TMP_Text highScoreText;
    public TMP_Text currentScoreText;
    public GameObject pauseMenu;

    void Start() { 
        highScoreText.SetText("High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString());
    }

    public void Play() {
        SceneManager.LoadScene(1);
    }

    public void Pause() { 
        currentScoreText.SetText("Current Score: " + PlayerPrefs.GetInt("Score", 0).ToString());
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Resume() {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void MainMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Quit() {
        Application.Quit();
    }
}
