using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDespawn : MonoBehaviour
{
    public float deleteY = -10f;

    void Update()
    {
        if (transform.position.y < deleteY)
        {
            Destroy(gameObject);
        }
    }
}
