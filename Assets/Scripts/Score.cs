using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour {

    public TMP_Text scoreText;
    public TMP_Text highScoreText;
    private int score = 0;

    void Start() {
        scoreText.SetText("0");
        PlayerPrefs.SetInt("Score", score);
        highScoreText.SetText("High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString());
    }

    void OnTriggerEnter2D(Collider2D obj) {
        
        if (obj.CompareTag("Player")) {

            if (score > PlayerPrefs.GetInt("HighScore", 0)) {
                PlayerPrefs.SetInt("HighScore", score);
            }
            
            SceneManager.LoadScene(2);
        }

        if (obj.CompareTag("Platform")) {
            
            score++;
            PlayerPrefs.SetInt("Score", score);
            scoreText.SetText(score.ToString());
            
            if (score > PlayerPrefs.GetInt("HighScore", 0)) {
                highScoreText.SetText("High Score: " + score);
            }

            Destroy(obj.gameObject);
        }
    }
}
