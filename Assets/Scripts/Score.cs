using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D obj) {
        if (obj.CompareTag("Player")) {
            Destroy(obj.gameObject);
        }
    }
}
