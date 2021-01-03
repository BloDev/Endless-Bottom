﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    Rigidbody2D rb;
    public GameObject effect;
    public float playerSpeed;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime, 0));
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Block")) {
            Instantiate(effect, transform.position, Quaternion.identity);
        }
    }
}
