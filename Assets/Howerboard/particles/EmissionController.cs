using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissionController : MonoBehaviour
{
    public Rigidbody engine;
    // Update is called once per frame
    void Update()
    {
        foreach(ParticleSystem ps in GetComponentsInChildren<ParticleSystem>())
        {
            ParticleSystem.EmissionModule em = ps.emission;
            if (GameStates.energyValue > 0)
                em.rateOverTime = engine.velocity.magnitude * 10;
            else
                em.rateOverTime = 1;

        }
    }
}
