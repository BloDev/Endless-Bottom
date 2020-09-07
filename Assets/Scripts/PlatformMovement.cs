using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    private float speed;

    // Update is called once per frame
    void Update()
    {
        speed = GameObject.Find("Spawner").GetComponent<PlatformSpawner>().platformSpeed;
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
