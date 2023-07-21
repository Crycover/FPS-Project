using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CameraData _cameraData;
    [SerializeField] private Transform _playerBody;

    private float xRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        _cameraData.MouseX = Input.GetAxis("Mouse X") * _cameraData.MouseSensivity;
        _cameraData.MouseY = Input.GetAxis("Mouse Y") * _cameraData.MouseSensivity;

        xRotation -= _cameraData.MouseY * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        _playerBody.Rotate(Vector3.up * _cameraData.MouseX * Time.deltaTime);
    }
}
