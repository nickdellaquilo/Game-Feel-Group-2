using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GlobalVars globalVars;
    private bool colorOn;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        globalVars = GameObject.Find("GlobalVars").GetComponent<GlobalVars>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        colorOn = globalVars.colorOn;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (colorOn) {
            spriteRenderer.color = new Color(Random.value, Random.value, Random.value);
            Debug.Log("Switch color");
        }
    }
}
