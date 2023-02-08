using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVars : MonoBehaviour
{
    [SerializeField] public bool colorOn = true;
    [SerializeField] public bool flashOn = true;
    [SerializeField] public bool prtclOn = true;
    [SerializeField] public bool shakeOn = true;
    [SerializeField] public bool soundOn = true;
    [SerializeField] public bool trailOn = true;

    public Toggle colorToggle;
    public Toggle flashToggle;
    public Toggle prtclToggle;
    public Toggle shakeToggle;
    public Toggle soundToggle;
    public Toggle trailToggle;

    void Awake()
    {
        colorToggle.onValueChanged.AddListener(delegate {
            ToggleColor();
        });

        flashToggle.onValueChanged.AddListener(delegate {
            ToggleFlash();
        });
    
        prtclToggle.onValueChanged.AddListener(delegate {
            ToggleParticle();
        });

        shakeToggle.onValueChanged.AddListener(delegate {
            ToggleShake();
        });

        soundToggle.onValueChanged.AddListener(delegate {
            ToggleSound();
        }); 

        trailToggle.onValueChanged.AddListener(delegate {
            ToggleTrail();
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

    void ToggleParticle()
    {
        prtclOn = !prtclOn;
    }

    void ToggleShake()
    {
        shakeOn = !shakeOn;
    }

    void ToggleSound()
    {
        soundOn = !soundOn;
    }

    void ToggleTrail()
    {
        trailOn = !trailOn;
    }
}
