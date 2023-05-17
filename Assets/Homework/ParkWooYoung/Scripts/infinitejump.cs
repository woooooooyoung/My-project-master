using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinitejump : MonoBehaviour
{
    private Rigidbody rigidbody;

    [SerializeField]
    private float jumpPower;

    private void Jump()
    {
        if (true)
        {
            rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            
        }
    }
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Jump();
    }
}
