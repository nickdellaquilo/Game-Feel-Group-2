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
        //colorToggle.onValueChanged.AddListener(new UnityAction<bool>(ToggleColor));
        //flashToggle.onValueChanged.AddListener(new UnityAction<bool>(ToggleFlash));
        //trailToggle.onValueChanged.AddListener(new UnityAction<bool>(ToggleTrail));
        //shakeToggle.onValueChanged.AddListener(new UnityAction<bool>(ToggleShake));
        //soundToggle.onValueChanged.AddListener(new UnityAction<bool>(ToggleSound));
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
