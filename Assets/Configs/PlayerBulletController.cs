using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerBulletController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 moveDir;
    private Animator animator;

    [SerializeField] private float moveSpeed;
    // [SerializeField] private float jumpPower;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletPoint;
    // [SerializeField] private float repeatTime;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        //rigidbody = GetComponent<Rigidbody>();
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
    // private void Jump()
    // {
    //     rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    // }
    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
    // private void OnJump(InputValue value)
    // {
    //     Jump();
    // }
     public void Fire()
     {
         Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
         animator.SetTrigger("Fire");
     }

     // private Coroutine bulletRoutine;
     // IEnumerator BulletRoutine()
     // {
     //     while (true)
     //     {
     //         Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
     //         yield return new WaitForSeconds(repeatTime);
     //     }
     // }
     //private void OnRepeatFire(InputValue value)
     //{
     //    if (value.isPressed)
     //    {
     //        bulletRoutine = StartCoroutine(BulletRoutine());
     //        animator.SetTrigger("Fire");
     //   }
     //    else
     //    {
     //        StopCoroutine(bulletRoutine);
     //    }
     //}
     private void OnFire(InputValue value)
     {
         Fire();
     }
 }