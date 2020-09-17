using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuScript : MonoBehaviour 
{
    public TMP_Text highScoreText;

    void Start() {
        highScoreText.SetText("High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString());
    }

    public void Play() {
        SceneManager.LoadScene(1);
    }

    public void Reset() {
        PlayerPrefs.DeleteAll();
        highScoreText.SetText("High Score: 0");
    }
}
