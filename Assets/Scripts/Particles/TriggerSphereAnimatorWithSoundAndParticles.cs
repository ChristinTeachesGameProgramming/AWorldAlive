using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TriggerSphereAnimatorWithSoundAndParticles : MonoBehaviour
{
    [SerializeField] private Animator _sphereAnimator;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private ParticleSystem _vanishingEffect;

    private void OnTriggerEnter(Collider collider)
    {
        _sphereAnimator.SetTrigger("Vanish");
        _audioSource.PlayOneShot(_audioSource.clip);
        
        _vanishingEffect.Clear();
        _vanishingEffect.Play();
    }

    private void OnTriggerExit(Collider collider)
    {
        _sphereAnimator.SetTrigger("Appear");
    }
}
