using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TriggerSphereAnimator : MonoBehaviour
{
    [SerializeField] private Animator _sphereAnimator;

    private void OnTriggerEnter(Collider collider)
    {
        _sphereAnimator.SetTrigger("Vanish");
    }

    private void OnTriggerExit(Collider collider)
    {
        _sphereAnimator.SetTrigger("Appear");
    }
}
