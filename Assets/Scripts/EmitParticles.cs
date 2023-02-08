using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitParticles : MonoBehaviour
{
    public GlobalVars globalVars;
    public ParticleSystem particleSystem;
    private bool prtclOn;

    void Start()
    {
        globalVars = GameObject.Find("GlobalVars").GetComponent<GlobalVars>();
    }

    void Update()
    {
        prtclOn = globalVars.prtclOn;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (prtclOn) {
            particleSystem.Emit(5);
        }
    }
}
