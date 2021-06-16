using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{    
    public Transform target;
    public float camSpeed = 3.0f;
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(new Vector3(transform.position.x, transform.position.y, -10),
            new Vector3(target.position.x, target.position.y, -10), Time.deltaTime * camSpeed);
    }
}

