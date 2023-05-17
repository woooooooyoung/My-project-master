using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class CowBulletController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 moveDir;

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpPower;
    [SerializeField] private float rotateSpeed;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private float repeatTime;     // ��� �ð�
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
        Rotate();
        
    }
    private void Move()
    {
        transform.Translate(Vector3.back * moveDir.z * moveSpeed * Time.deltaTime, Space.Self);
    }
    private void Rotate()
    {
        transform.Rotate(Vector3.up, moveDir.x * rotateSpeed * Time.deltaTime);
    }
     private void Jump()
     {
         rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);

     }
    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
        // x �� �� �̵�
        // y �߷��� �ݴ����
        // z �� ��
    }

    private void OnJump(InputValue value)
    {
        Jump();
    }
    private void OnFire(InputValue value) // ��ư��� : �������� ��
    {
        // Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
    }

    private Coroutine bulletRoutine;
    IEnumerator BulletMakeRoutine()
    {
        while (true)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            yield return new WaitForSeconds(repeatTime);
        }
    }
    private void OnRepeatFire(InputValue value)
    {
        if (value.isPressed)
        {
            bulletRoutine = StartCoroutine(BulletMakeRoutine());
            Debug.Log("������");
        }
        else
        {
            StopCoroutine(bulletRoutine);
            Debug.Log("������");
        }
    }

}
