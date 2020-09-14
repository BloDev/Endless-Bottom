using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score = 0;

    void Update()
    {
        scoreText.SetText(score.ToString());
    }

    void OnTriggerEnter2D(Collider2D obj) {
        if (obj.CompareTag("Player")) {
            Destroy(obj.gameObject);
        }

        if (obj.CompareTag("Platform")) {
            score++;
        }
    }
}
