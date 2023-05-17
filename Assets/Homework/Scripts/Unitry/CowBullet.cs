using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))] // bullet��ũ��Ʈ�� ���� ������ٵ�� �ڵ����� �ٰ� bullet�� ��������� ������ٵ� ������
public class CowBullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;

    private Rigidbody rigidbody; // bullet�� Rigidbody�� ������
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Rotate();
    }
    private void Start()
    {
        rigidbody.velocity = -transform.forward * bulletSpeed; // �չ������� bulletSpeed��ŭ ���ư� velocity : �ӷ�
        Destroy(gameObject, 5f); // 5�ʵ� bullet�� ����
    }

    private void Rotate()
    {
        transform.Rotate(0, 180, 0);
    }
}
