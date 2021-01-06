using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    Rigidbody2D rb;
    public GameObject effect;
    public float playerSpeed;
    private float particleLifetime = 0.25f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        rb.AddForce(new Vector2(Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime, 0));
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Platform") {
            GameObject landingParticle = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(landingParticle, particleLifetime);
        }
    }
}
