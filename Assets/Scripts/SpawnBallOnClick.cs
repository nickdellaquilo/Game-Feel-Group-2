using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallOnClick : MonoBehaviour
{
    public GameObject Ball;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 instantiatePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            instantiatePosition.z = 0;
            Instantiate(Ball, instantiatePosition, Quaternion.identity);
        }
    }
}
