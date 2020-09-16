using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

    public float endY; 
    public float backgroundSpeed; 
    private float height; 
  
    void Update() {   

        transform.position = new Vector3(transform.position.x, transform.position.y + backgroundSpeed * Time.deltaTime, transform.position.z);  
        
        if (transform.position.y >= endY) {
            transform.position = new Vector3(transform.position.x, endY * -1, transform.position.z); 
        }
    }
}
