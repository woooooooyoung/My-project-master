using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MainCamera : MonoBehaviour
{
    // Culling Mask : 카메라에 비춰지면 안돼는게 있으면 체크 해제
    // Fiield of View : 시야 각 크면 넓게 작으면 좁게 카메라를 기준으로 설정한 각도
    // Clipping Planes : 얼마만큼 멀리볼것인지 짧게 볼것인지
    // Viewport Rect : 멀마만큼의 정사각형만큼 보여줄것인지, 이걸 활용해서 화면을 쪼개 2인용게임도 만들 수 있음 ex. 잇 테이크 투, 어 웨이 아웃
    // 

    /*
    public GameObject Camera;           // 카메라가 따라다닐 타겟
    
    public float offsetX = 0.0f;        // 카메라의 x좌표
    public float offsetY = 10.0f;       // 카메라의 y좌표
    public float offsetZ = -10.0f;      // 카메라의 z좌표
    
    public float CameraSpeed = 10.0f;   // 카메라 속도
    Vector3 TargetPos;                  // 타겟의 위치
    
    private void FixedUpdate()
    {
        TargetPos = new Vector3(
            Target.transform.position.x + offsetX,
            Target.transform.position.y + offsetY,
            Target.transform.position.z + offsetZ
            );
    
        transform.position = Vector3.Lerp(transform.position, TargetPos, Time.deltaTime * CameraSpeed);
        // 카메라의 움직임을 부드럽게 하는 함수(Lerp)
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
