using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVars : MonoBehaviour
{
    [SerializeField] public bool colorOn = true;
    [SerializeField] public bool trailOn = true;
    [SerializeField] public bool shakeOn = true;
    [SerializeField] public bool soundOn = true;

    public void ToggleScreenShake()
    {
        shakeOn = !shakeOn;
    }
}
