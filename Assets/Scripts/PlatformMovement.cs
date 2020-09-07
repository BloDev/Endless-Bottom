using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    Rigidbody2D rb;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = GameObject.Find("Spawner").GetComponent<PlatformSpawner>().platformSpeed;
        rb.MovePosition(transform.position + transform.up * speed * Time.deltaTime);
    }
}
