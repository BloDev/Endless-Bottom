using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col) {
        
        if (col.gameObject.CompareTag("Player")) {

            if (PlayerPrefs.GetInt("Score", 0) > PlayerPrefs.GetInt("HighScore", 0)) {
                PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score", 0));
            }
            
            SceneManager.LoadScene(2);
        }
    }
}
