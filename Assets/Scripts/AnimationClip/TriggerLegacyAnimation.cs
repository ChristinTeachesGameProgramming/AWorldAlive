using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TriggerLegacyAnimation : MonoBehaviour
{
    [SerializeField] private SphereLegacyAnimation vanishingObject;

    private void OnTriggerEnter(Collider collider)
    {
        vanishingObject.Vanish();
    }

    private void OnTriggerExit(Collider collider)
    {
        vanishingObject.Appear();
    }
}
