using UnityEngine;

public class MovePosition : MonoBehaviour
{

    private float _speedX = 10f;
    private float _speedY = 15f;
    private float _jumpPower = 5f;
    Rigidbody rb;
    // Update is called once per frame

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position += transform.right * Input.GetAxis("Horizontal") * _speedX * Time.deltaTime;
        transform.position += transform.right *  - Input.GetAxis("Horizontal") * - _speedX * Time.deltaTime;
        transform.position += transform.forward * Input.GetAxis("Vertical") * _speedY * Time.deltaTime;
        transform.position += transform.forward *  - Input.GetAxis("Vertical") * - _speedY * Time.deltaTime;

        if (Input.GetButton("Jump"))
        {
            rb.AddForce(transform.up * _jumpPower);
        }
    }

    private void FixedUpdate()
    {
        
    }
}
