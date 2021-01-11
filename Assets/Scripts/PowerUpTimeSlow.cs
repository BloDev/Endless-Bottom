using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTimeSlow : MonoBehaviour
{
    public GameObject spawner;
    private float initialSpawnSpeed;

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.gameObject.tag == "Player") {
            gameObject.GetComponent<Renderer>().enabled = false;
            StartCoroutine(slowTime());
        }
    }

    IEnumerator slowTime() {

        GameObject.Find("Spawner").GetComponent<PlatformSpawner>().platformSpeed = 2.5f;
        GameObject.Find("Spawner").GetComponent<PlatformSpawner>().spawnTimer *= 2;
        yield return new WaitForSeconds(5);
        GameObject.Find("Spawner").GetComponent<PlatformSpawner>().platformSpeed = 5;
        GameObject.Find("Spawner").GetComponent<PlatformSpawner>().spawnTimer *= 0.5f;
        Destroy(gameObject);
    }
}