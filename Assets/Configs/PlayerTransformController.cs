using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerTransformController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 moveDir;

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpPower;
    [SerializeField]
    private float rotateSpeed;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
        Rotate();
        // LookAt();
    }
    private void Move()
    {
        // transform.position += moveDir * moveSpeed * Time.deltaTime;
        // transform.Translate(moveDir * moveSpeed * Time.deltaTime);
        //transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);
        transform.Translate(Vector3.forward * moveDir.z * moveSpeed * Time.deltaTime, Space.Self);
        // transform.Rotate(moveDir, Space.Self);
        // transform.position = new Vector3(0, 0, 0);

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
        // x 좌 우 이동
        // y 중력의 반대방향
        // z 앞 뒤
    }
    private void OnJump(InputValue value)
    {
        Jump();
    }



    public void LookAt() // 지정한 목적지를 바라봄
    {
        transform.LookAt(new Vector3(0, 0, 0));
    }
    public void Rotation()
    {

    }


}
