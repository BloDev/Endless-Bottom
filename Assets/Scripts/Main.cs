using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Main : MonoBehaviour 
{
    public GameObject pauseMenu;

    public void Pause() { 
        FindObjectOfType<AudioManager>().Play("Pause Sound");
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Resume() {
        FindObjectOfType<AudioManager>().Play("Unpause Sound");
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    public void MainMenu() {
        FindObjectOfType<AudioManager>().Play("Button Clicking Sound");
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
