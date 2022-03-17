using UnityEngine;


// Performs a mouse look.

public class RotationY : MonoBehaviour
{

    private float _verticalSpeed = 2.0f;
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        float _verticalMovie = - _verticalSpeed * Input.GetAxis("Mouse Y");

       
        transform.Rotate(_verticalMovie, 0, 0);
    }
}