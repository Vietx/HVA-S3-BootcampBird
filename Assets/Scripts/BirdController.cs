using UnityEngine;
using UnityEngine.InputSystem;

public class BirdController : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
}
