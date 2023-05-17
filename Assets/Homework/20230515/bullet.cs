using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]               
public class bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    private Rigidbody rigidbody;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        rigidbody.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 5f);
    }


}
