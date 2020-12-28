using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

    public float endY; 
    private float backgroundSpeed; 

    void FixedUpdate() {   
        backgroundSpeed = GameObject.Find("Spawner").GetComponent<PlatformSpawner>().platformSpeed;

        foreach (Transform child in transform) {
            child.Translate(Vector2.up * backgroundSpeed * Time.deltaTime);
            if (child.position.y >= endY) {
                child.position = new Vector3(child.position.x, endY * -1, child.position.z); 
            }
            backgroundSpeed = backgroundSpeed / (float)1.5; 
        }
    }
}
