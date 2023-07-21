using UnityEngine;

[CreateAssetMenu(menuName = "Player / Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private float _speed;
    public float Speed { get { return _speed; } set { _speed = value; } }

    [SerializeField] private Vector3 _move;
    public Vector3 Move { get { return _move; } set { _move = value; } }

    [SerializeField] private float _gravity;
    public float Gravity { get { return _gravity; } set { _gravity = value; } }

    [SerializeField] private float _jumpForce;
    public float JumpForce { get { return _jumpForce; } set { _jumpForce = value; } }
}
