using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public GameObject target; 
    private float startPos; 
    private float height; 
    public float parallaxEffect; 

    void Start()
    {
        startPos = transform.position.y; 
        height = GetComponent<SpriteRenderer>().bounds.size.y;
    }
  
    void Update()
    {   
        transform.position = new Vector3(transform.position.x, transform.position.y + parallaxEffect, transform.position.z);  
        
        if (transform.position.y - startPos >= height) {
            float offset = (transform.position.y - startPos) % height;
            transform.position = new Vector3(transform.position.x, transform.position.y - offset, transform.position.z); 
        }
    }
}
