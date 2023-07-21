using UnityEngine;

[CreateAssetMenu(menuName = "Camera / Camera Data")]
public class CameraData : ScriptableObject
{
    [SerializeField] private float _mouseSensivity;
    public float MouseSensivity { get { return _mouseSensivity; } set { _mouseSensivity = value; } }

    [SerializeField] private float _mouseX;
    public float MouseX { get { return _mouseX; } set { _mouseX = value; } }

    [SerializeField] private float _mouseY;
    public float MouseY { get { return _mouseY; } set { _mouseY = value; } }
}
