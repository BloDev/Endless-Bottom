using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {
    
    Rigidbody2D rb;
    private float speed;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        speed = GameObject.Find("Spawner").GetComponent<PlatformSpawner>().platformSpeed;
        rb.MovePosition(transform.position + transform.up * speed * Time.deltaTime);
    }
}
