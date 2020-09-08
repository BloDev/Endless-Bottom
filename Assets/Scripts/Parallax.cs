using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public GameObject target; 
    private float startPos; 
    private float height; 
    public float parallaxEffect; 


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.y; 
        // height = GetComponent<SpriteRenderer>().bounds.size.y; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = target.transform.position.y * parallaxEffect;
        transform.position = new Vector3(transform.position.x, startPos - distance, transform.position.z);  
    }
}
