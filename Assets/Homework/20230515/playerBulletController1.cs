using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerBulletController1 : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 moveDir;
    private Animator animator;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletPoint;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        Move();
        Rotate();

    }
    private void Move()
    {
        transform.Translate(Vector3.forward * moveDir.z * moveSpeed * Time.deltaTime, Space.Self);
    }
    private void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime);
    }
    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
    public void Fire()
    {
        Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        animator.SetTrigger("Fire");
    }
    private void OnFire(InputValue value)
    {
        // Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        // animator.SetTrigger("Fire");
        Fire();
        
    }

}

