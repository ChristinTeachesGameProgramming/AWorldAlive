using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TriggerSphereAnimatorWithSound : MonoBehaviour
{
    [SerializeField] private Animator _sphereAnimator;
    [SerializeField] private AudioSource _audioSource;

    private void OnTriggerEnter(Collider collider)
    {
        _sphereAnimator.SetTrigger("Vanish");
        _audioSource.PlayOneShot(_audioSource.clip);
    }

    private void OnTriggerExit(Collider collider)
    {
        _sphereAnimator.SetTrigger("Appear");
    }
}
