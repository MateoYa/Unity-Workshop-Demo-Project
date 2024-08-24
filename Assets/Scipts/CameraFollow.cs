using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private float offest;

    // Update is called once per frame
    private void Start()
    {
        offest = transform.position.x - player.position.x;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x + offest, transform.position.y, transform.position.z);
    }
}
