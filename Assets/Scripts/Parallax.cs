using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public GameObject target; 
    private float startPos; 
    private float currentPos;
    public float parallaxEffect; 

    /*
    void Start()
    {
        startPos = transform.position.y; 
    }
    */

    void Update()
    {   
        /*
        currentPos = transform.position.y; 
        float distance = target.transform.position.y * parallaxEffect;

        if (startPos - distance >= currentPos) {
            transform.position = new Vector3(transform.position.x, startPos - distance, transform.position.z);  
        }
        */

        transform.position = new Vector3(transform.position.x, transform.position.y + parallaxEffect, transform.position.z);  
    }
}
