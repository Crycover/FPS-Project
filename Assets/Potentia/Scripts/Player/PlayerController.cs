using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private InputData _inputData;
    [SerializeField] private CharacterController _charactarController;

    private Vector3 _velocity;

    [Header("Jump")]
    public Transform groundCheck;
    public LayerMask groundLayer;
    private bool _isGrounded;
    void Update()
    {
        MyInput();
        Movement();
        Gravity();
    }

    void MyInput()
    {
        _inputData.Horizontal = Input.GetAxis("Horizontal");
        _inputData.Vertical = Input.GetAxis("Vertical");
    }

    void Movement()
    {
        _playerData.Move = transform.right * _inputData.Horizontal + transform.forward * _inputData.Vertical;
        _charactarController.Move(_playerData.Move * _playerData.Speed * Time.deltaTime);
    }

    #region Jump
    void Gravity()
    {
        _isGrounded = Physics.CheckSphere(groundCheck.position, 0.3f, groundLayer);

        if(_isGrounded && _velocity.y < 0 )
            _velocity.y = -1f;

        if (_isGrounded)
        {
            Debug.Log(_isGrounded);
            if (Input.GetButtonDown("Jump"))
            {
                Jump();
            }
        }
        else
        {
            Debug.Log(_isGrounded);
            _velocity.y += _playerData.Gravity * Time.deltaTime;
        }

        _charactarController.Move(_velocity * Time.deltaTime);
    }

    void Jump()
    {
        _velocity.y = Mathf.Sqrt(_playerData.JumpForce * 2 * -_playerData.Gravity);
    }
    #endregion
}
