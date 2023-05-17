using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))] 
public class TurretBullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject explosionEffect;

    private Rigidbody rigidbody; 
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }
    private void Start()
    {
        rigidbody.velocity = transform.forward * bulletSpeed; 
        Destroy(gameObject, 1f); 
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }



}
