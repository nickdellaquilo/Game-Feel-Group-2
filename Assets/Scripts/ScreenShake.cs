using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    //UserInterface UI = gameObject.GetComponent<UserInterface>();

    public float shakeDuration = 0.5f;
    public float shakeMagnitude = 0.5f;
    public GlobalVars globalVars;
    private Vector3 originalPos;
    private bool shake = true;

    void Awake()
    {
        globalVars = GameObject.Find("EventSystem").GetComponent<GlobalVars>();
    }

    void Update()
    {
        shake = globalVars.shakeOn;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (shake) {
            originalPos = Camera.main.transform.position;
            InvokeRepeating("StartShaking", 0f, 0.01f);
            Invoke("StopShaking", shakeDuration);
        }
    }

    void StartShaking()
    {
        float shakeX = Random.Range(-1f, 1f) * shakeMagnitude;
        float shakeY = Random.Range(-1f, 1f) * shakeMagnitude;
        Camera.main.transform.position = originalPos + new Vector3(shakeX, shakeY, 0f);
    }

    void StopShaking()
    {
        CancelInvoke("StartShaking");
        Camera.main.transform.position = originalPos;
    }
}
