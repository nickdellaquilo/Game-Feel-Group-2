using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSound : MonoBehaviour
{
    public AudioClip sound;
    [SerializeField] public float pitchMin = 0.9f;
    [SerializeField] public float pitchMax = 1.1f;
    public GlobalVars globalVars;
    private AudioSource audioSource;
    private bool soundOn = true;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        globalVars = GameObject.Find("GlobalVars").GetComponent<GlobalVars>();
    }

    void Update()
    {
        soundOn = globalVars.soundOn;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (soundOn) {
        audioSource.pitch = Random.Range(pitchMin, pitchMax);
        audioSource.PlayOneShot(sound);
        }
    }
}
