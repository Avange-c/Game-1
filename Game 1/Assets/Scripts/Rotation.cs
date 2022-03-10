using UnityEngine;
using System.Collections;

// Performs a mouse look.

public class Rotation : MonoBehaviour
{
    
    public float _horizontalSpeed = 2.0f;
    public float _verticalSpeed = 2.0f;
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;

        float _movieX = 0 * Input.GetAxis("Vertical") * Input.GetAxis("Horizontal");
        float _horizontalMovie = _horizontalSpeed * Input.GetAxis("Mouse X");
        

        transform.Rotate(0, _horizontalMovie, 0);
    }
}