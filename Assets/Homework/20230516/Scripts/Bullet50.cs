using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet50: MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private GameObject ExplosiveEffect;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.velocity = transform.forward * moveSpeed;
        Destroy(gameObject, 3f);
    }
    private void OnCollisionEnter(Collision collision)
    {
       Instantiate(ExplosiveEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
