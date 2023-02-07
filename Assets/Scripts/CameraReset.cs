using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, -10), speed * Time.deltaTime);
    }
}
