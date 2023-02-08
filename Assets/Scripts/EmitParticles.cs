using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitParticles : MonoBehaviour
{
    public ParticleSystem particleSystem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        particleSystem.Emit(5);
    }
}
