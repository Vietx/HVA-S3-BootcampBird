using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdController : MonoBehaviour
{
    private Rigidbody rb;
    private float direction = 0;
    private float jump = 0;

    InputAction horizontal;
    InputAction vertical;

    public float speed = 10;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        horizontal = InputSystem.actions.FindAction("Movement");
        vertical = InputSystem.actions.FindAction("Jump");
    }

    // void Update()
    // {
    //     float move = horizontal.ReadValue<float>();
    //     Debug.Log(move);
    // }

    void OnMovement(InputValue val)
    {
        float directionValue = val.Get<float>();
        direction = directionValue;
    }

    void OnJump(InputValue val)
    {
        float jumpValue = val.Get<float>();
        jump = jumpValue;
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(direction, jump, 0.0f);
        rb.AddForce(movement * speed);
    }
}
