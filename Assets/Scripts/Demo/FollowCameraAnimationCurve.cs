using UnityEngine;

public class FollowCameraAnimationCurve : MonoBehaviour
{
    [SerializeField][Range(0.1f, 1)] private float _speed = 1f;
    [SerializeField] private AnimationCurve _animationCurve;
    public Transform Player;

    private Vector3 _initalOffset;

    private Vector3 _startPosition;
    private Vector3 _targetPosition;
    private Vector3 _lastPlayerPosition;
    private float _animationTime;

    void Start()
    {
        _initalOffset = transform.position - Player.position;
        UpdatePath();
    }

    void FixedUpdate()
    {
        if (Player.position != _lastPlayerPosition)
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
        _targetPosition = Player.position + _initalOffset;
        _lastPlayerPosition = Player.position;
        _animationTime = 0;
    }
}