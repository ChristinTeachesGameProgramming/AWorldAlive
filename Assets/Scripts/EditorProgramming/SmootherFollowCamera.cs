using UnityEngine;

public class SmootherFollowCamera : MonoBehaviour
{
    [SerializeField][Range(0.1f, 1)] private float _speed = 1f;
    [SerializeField] private AnimationCurve _animationCurve;
    public Transform TargetObject;

    private Vector3 _initalOffset;

    private Vector3 _startPosition;
    private Vector3 _targetPosition;
    private Vector3 _lastTargetObjectPosition;
    private float _animationTime;

    void Start()
    {
        _initalOffset = transform.position - TargetObject.position;
        UpdatePath();
    }

    void FixedUpdate()
    {
        if (TargetObject.position != _lastTargetObjectPosition)
        {
            UpdatePath();
        }

        _animationTime += Time.deltaTime;

        var step = _animationCurve.Evaluate(_animationTime * 1 / _speed);
        transform.position = Vector3.Lerp(_startPosition, _targetPosition, step);
    }

    private void UpdatePath()
    {
        _startPosition = transform.position;
        _targetPosition = TargetObject.position + _initalOffset;
        _lastTargetObjectPosition = TargetObject.position;
        _animationTime = 0;
    }
}