using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MainCamera : MonoBehaviour
{
    // Culling Mask : ī�޶� �������� �ȵŴ°� ������ üũ ����
    // Fiield of View : �þ� �� ũ�� �а� ������ ���� ī�޶� �������� ������ ����
    // Clipping Planes : �󸶸�ŭ �ָ��������� ª�� ��������
    // Viewport Rect : �ָ���ŭ�� ���簢����ŭ �����ٰ�����, �̰� Ȱ���ؼ� ȭ���� �ɰ� 2�ο���ӵ� ���� �� ���� ex. �� ����ũ ��, �� ���� �ƿ�
    // 

    /*
    public GameObject Camera;           // ī�޶� ����ٴ� Ÿ��
    
    public float offsetX = 0.0f;        // ī�޶��� x��ǥ
    public float offsetY = 10.0f;       // ī�޶��� y��ǥ
    public float offsetZ = -10.0f;      // ī�޶��� z��ǥ
    
    public float CameraSpeed = 10.0f;   // ī�޶� �ӵ�
    Vector3 TargetPos;                  // Ÿ���� ��ġ
    
    private void FixedUpdate()
    {
        TargetPos = new Vector3(
            Target.transform.position.x + offsetX,
            Target.transform.position.y + offsetY,
            Target.transform.position.z + offsetZ
            );
    
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
        // ī�޶��� �������� �ε巴�� �ϴ� �Լ�(Lerp)
    }
    */

    /*
    public class CameraController : MonoBehaviour
    {
        [SerializeField]
        private GameObject follow;
        [SerializeField]
        private GameObject lookAt;

        [SerializeField]
        private Vector3 offset;

        private void LateUpdate()
        {
            transform.position = follow.transform.position + offset;
            transform.LookAt(lookAt.transform);
        }
    }
    */
}
