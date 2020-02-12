using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    //  Initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // move the camera with the player
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
