using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashScreen : MonoBehaviour
{
    public float flashDuration = 0.1f;
    public Color flashColor = Color.white;
    public GlobalVars globalVars;
    private SpriteRenderer spriteRenderer;
    private bool flashOn = true;

    private void Start()
    {
        globalVars = GameObject.Find("GlobalVars").GetComponent<GlobalVars>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() 
    {
        flashOn = globalVars.flashOn;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(Flash());
    }

    private IEnumerator Flash()
    {
        spriteRenderer.color = flashColor;
        yield return new WaitForSeconds(flashDuration);
        spriteRenderer.color = Color.white;
    }
}
