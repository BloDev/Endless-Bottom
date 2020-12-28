using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PauseMenuScript : MonoBehaviour
{
    public TMP_Text highScoreText;
    private static bool GameIsPaused = false;

    void Start() {
        highScoreText.SetText("High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log("Escape key was pressed");
            if (GameIsPaused) {
                Resume();
            }
            else {
                Pause();
            }
        }
    }

    void Pause() {
        Time.timeScale = 0f; 
        SceneManager.LoadScene(2);
        GameIsPaused = true;
    }

    public void Resume() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
        GameIsPaused = false; 
    }

    public void Quit() {
        Application.Quit();
    }
}
