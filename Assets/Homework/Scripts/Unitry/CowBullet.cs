using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))] // bullet스크립트를 쓰면 리지드바디는 자동으로 붙고 bullet을 지우기전엔 리지드바디도 못지움
public class CowBullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;

    private Rigidbody rigidbody; // bullet은 Rigidbody에 의존함
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Rotate();
    }
    private void Start()
    {
        rigidbody.velocity = -transform.forward * bulletSpeed; // 앞방향으로 bulletSpeed만큼 날아감 velocity : 속력
        Destroy(gameObject, 5f); // 5초뒤 bullet을 지움
    }

    private void Rotate()
    {
        transform.Rotate(0, 180, 0);
    }
}
