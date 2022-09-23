using UnityEngine;

public class FollowCameraAnimationCurve : MonoBehaviour
{
    [SerializeField] private float _smoothness = 1f;
    [SerializeField] private AnimationCurve _animationCurve;
    public Transform Player;

    private Vector3 initalOffset;
    private Vector3 cameraPosition;


    void Start()
    {  
        initalOffset = transform.position - Player.position;
    }

    void FixedUpdate()
    {
        cameraPosition = Player.position + initalOffset;
        var step = _animationCurve.Evaluate(Time.fixedDeltaTime) * _smoothness;
        transform.position = Vector3.Lerp(transform.position, cameraPosition, step);
    }
}