using UnityEngine;

public class SmootherFollowCamera : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private AnimationCurve _smoothnessCurve;
    [SerializeField] private Transform _targetObject;

    public Transform TargetObject => _targetObject;

    private Vector3 initalOffset;
    private Vector3 cameraPosition;

    void Start()
    {  
        initalOffset = transform.position - _targetObject.position;
    }

    void FixedUpdate()
    {
        cameraPosition = _targetObject.position + initalOffset;
        var smoothness = _smoothnessCurve.Evaluate(Time.fixedDeltaTime) * _speed;
        transform.position = Vector3.Lerp(transform.position, cameraPosition, smoothness);
    }
}