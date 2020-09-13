using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float height; 
    public float endY; 
    public float backgroundSpeed; 
  
    void Update()
    {   
        transform.position = new Vector3(transform.position.x, transform.position.y + backgroundSpeed * 10 * Time.deltaTime, transform.position.z);  
        
        if (transform.position.y >= endY) {
            transform.position = new Vector3(transform.position.x, endY * -1, transform.position.z); 
        }
    }
}
