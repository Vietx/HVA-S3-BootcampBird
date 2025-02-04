using UnityEngine;
using UnityEngine.InputSystem;

public class BirdController : MonoBehaviour
{
    private Rigidbody rb;

    private float movementY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnVerticalmovement(InputValue mv)
    {
        Vector2 movementVector = mv.Get<Vector2>();
        movementY = movementVector.y;
    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.up * 10);
    }
}
