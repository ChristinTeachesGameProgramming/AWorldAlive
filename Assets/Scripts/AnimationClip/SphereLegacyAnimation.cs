using UnityEngine;

[RequireComponent(typeof(Animation))]
public class SphereLegacyAnimation : MonoBehaviour
{
    [SerializeField] private AnimationClip _idleAnimation;
    [SerializeField] private AnimationClip _vanishAnimation;
    [SerializeField] private AnimationClip _appearAnimation;

    private Animation _animation;

    private void Awake()
    {
        _animation = GetComponent<Animation>();
        _animation.Play(_idleAnimation.name);
    }

    public void Vanish()
    {
        _animation.Play(_vanishAnimation.name);
    }

    public void Appear()
    {
        _animation.Play(_appearAnimation.name);
    }

    public void Idle()
    {
        _animation.Play(_idleAnimation.name);
    }
}
