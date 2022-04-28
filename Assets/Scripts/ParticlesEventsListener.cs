using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlesEventsListener : MonoBehaviour
{
    private ParticleSystem _particleSystem;

    private Harvester _harvester;

    private void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();

        _harvester = GetComponentInParent<Harvester>();

        _harvester.OnItemAdded += MagicMoment;
    }

    private void MagicMoment(Vector2 fxPos)
    {
        _particleSystem.transform.position = fxPos;
        _particleSystem.Play();
    }
        
}
