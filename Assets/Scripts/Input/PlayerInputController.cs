using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerInputController : MonoBehaviour
{
    [SerializeField] [Range(.1f, 1)] private float _playerSpeed;

    private Vector2 _moveInput;
    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        _moveInput = context.ReadValue<Vector2>();
        // Debug.Log($"moveInput: {_moveInput}");
    }

    private void FixedUpdate()
    {
        var moveVector = new Vector3(_moveInput.x, 0, _moveInput.y);
        _characterController.Move( moveVector * _playerSpeed);
    }
}
