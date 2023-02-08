using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVars : MonoBehaviour
{
    [SerializeField] public bool colorOn = true;
    [SerializeField] public bool flashOn = true;
    [SerializeField] public bool trailOn = true;
    [SerializeField] public bool shakeOn = true;
    [SerializeField] public bool soundOn = true;

    public Toggle colorToggle;
    public Toggle flashToggle;
    public Toggle trailToggle;
    public Toggle shakeToggle;
    public Toggle soundToggle;

    void Awake()
    {
        colorToggle.onValueChanged.AddListener(delegate {
            ToggleColor();
        });

        flashToggle.onValueChanged.AddListener(delegate {
            ToggleFlash();
        });
    
        trailToggle.onValueChanged.AddListener(delegate {
            ToggleTrail();
        });

        shakeToggle.onValueChanged.AddListener(delegate {
            ToggleShake();
        });

        soundToggle.onValueChanged.AddListener(delegate {
            ToggleSound();
        }); 
    }

    void ToggleColor()
    {
        colorOn = !colorOn;
    }

    void ToggleFlash()
    {
        flashOn = !flashOn;
    }

    void ToggleTrail()
    {
        trailOn = !trailOn;
    }

    void ToggleShake()
    {
        shakeOn = !shakeOn;
    }

    void ToggleSound()
    {
        soundOn = !soundOn;
    }
}
