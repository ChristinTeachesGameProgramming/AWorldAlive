using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] [Range(5,10)] private float _smoothness;
    [SerializeField] private Transform _targetObject;

    private Vector3 initalOffset;
    private Vector3 cameraPosition;

    void Start()
    {  
        initalOffset = transform.position - _targetObject.position;
    }

    void FixedUpdate()
    {
        cameraPosition = _targetObject.position + initalOffset;
        transform.position = Vector3.Lerp(transform.position, cameraPosition, _smoothness*Time.fixedDeltaTime);
    }
}