using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraWidth;

    // Start is called before the first frame update
    void Start()
    {
        Camera.main.orthographicSize = (cameraWidth / 2) / Camera.main.aspect;
    }
}
