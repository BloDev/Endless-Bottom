using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

    public float endY; 
    public float startY;
    private float backgroundSpeed; 

    void Update() {   
        /*
        transform.Translate(Vector2.up * backgroundSpeed * Time.deltaTime);
        
        if (transform.position.y >= endY) {
            transform.position = new Vector2(transform.position.x, endY * -1); 
        }
        */
        backgroundSpeed = GameObject.Find("Spawner").GetComponent<PlatformSpawner>().platformSpeed;

        foreach (Transform child in transform) {
            child.Translate(Vector2.up * backgroundSpeed * Time.deltaTime);
            if (child.position.y >= endY) {
                child.position = new Vector2(child.position.x, endY * -1); 
            }
            backgroundSpeed = backgroundSpeed / 2; 
        }
    }
}
