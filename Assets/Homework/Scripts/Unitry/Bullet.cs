using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))] // bullet��ũ��Ʈ�� ���� ������ٵ�� �ڵ����� �ٰ� bullet�� ��������� ������ٵ� ������
public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject explosionEffect;

    private Rigidbody rigidbody; // bullet�� Rigidbody�� ������
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }
    private void Start()
    {
        rigidbody.velocity = transform.forward * bulletSpeed; // �չ������� bulletSpeed��ŭ ���ư� velocity : �ӷ�
        Destroy(gameObject, 5f); // 5�ʵ� bullet�� ����
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }



}
