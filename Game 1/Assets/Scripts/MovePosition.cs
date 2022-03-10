using UnityEngine;

public class MovePosition : MonoBehaviour
{

    public float _speedX = 1f;
    public float _speedY = 15f;
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * Input.GetAxis("Horizontal") * _speedX * Time.deltaTime;
        transform.position += transform.right *  - Input.GetAxis("Horizontal") * - _speedX * Time.deltaTime;
        transform.position += transform.forward * Input.GetAxis("Vertical") * _speedY * Time.deltaTime;
        transform.position += transform.forward *  - Input.GetAxis("Vertical") * - _speedY * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        
    }
}
