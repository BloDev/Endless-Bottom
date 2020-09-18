using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour {

    private int score;

    void OnCollisionEnter2D(Collision2D col) {
        
        if (col.gameObject.CompareTag("Player")) {

            score = GameObject.Find("TopCollider").GetComponent<Score>().score;
            
            Destroy(col.gameObject);
            
            if (score > PlayerPrefs.GetInt("HighScore", 0)) {
                PlayerPrefs.SetInt("HighScore", score);
            }
            
            SceneManager.LoadScene(0);
        }
    }
}
