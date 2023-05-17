using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMessageEvent : MonoBehaviour
{
    /************************************************************************
	 * 유니티메시지 이벤트함수
	 * 
	 * 유니티가 보내는 메시지에 반응하는 함수
	 * 포함할 경우 유니티메시지에 반응하지만, 포함하지 않을 경우 무시함
	 * 스크립트는 유니티 엔진이 보내는 메시지에 반응하여 자신의 행동을 정의
	 ************************************************************************/
    
    private void Awake()
    {
        // 포함이 안될시 1회 호출되는 함수를 안가지고 있을 뿐임
        // 스크립트가 씬에 포함되었을 때 1회 호출되는 함수
        // 스크립트가 비활성화 되어 있는 경우에도 호출됨

        // 역할 : 스크립트가 필요로 하는 초기화 작업 진행
        //		  (게임상황과 무관한 나만의 초기화 작업)
        // ex) 데이터 초기화, 컴포넌트 연결을 진행
        // 스타트는 동작(업데이트하는)함수 직전에 딱 한번만 호출되는 동작직전에 호출되는 함수지만 어웨이크는 게임이 준비가 안돼어있어도 호출되는 함수임
        Debug.Log("Awake");
    }
    private void Start()
    {
        // 스크립트가 씬에 처음으로 Update하기 직전에 1회 호출됨
        // 게임이 모두 마련이 된다음 동작 직전에 호출하는 함수(몬스터따로 플레이어 따로 마련되있는 경우가 아닌 전부 다 마련되야만 호출됨)
        // 스크립트가 비활성화된 경우 호출되지 않음

        // 역할 : 스크립트가 필요로 하는 초기화 작업 진행
        //		  (게임상황이 영향을 줄 수 있는 작업)
        // ex) 몬스터의 플레이어 타겟선정
        Debug.Log("Start");
    }

    private void OnEnable()
    {


        // 스크립트가 활성화될 때마다 호출
        // 동작한다 하면 OnEnable이 호출 동작이 안된다면 OnDisable이 호출됨

        // 역할 : 스크립트가 활성화 되었을 때 작업 진행
        Debug.Log("OnEnable");
    }
    private void OnDisable()
    {
        // 스크립트가 비활성화될 때마다 호출



        // 역할 : 스크립트가 비활성화 되었을 때 작업 진행
        Debug.Log("OnDisable");
    }


    private void Update()
    {
        // Update는 기본적으로 파란색을 가진 함수

        // 게임의 프레임마다 호출

        // 역할 : 핵심 게임 로직 구현


        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // 씬의 모든 게임오브젝트의 Update가 진행된 후 호출1
        // 후처리에 필요한게 LateUpdate
        // 역할 : 게임프레임의 진행 결과가 필요한 동작이 있는 기능 구현
        // ex) 플레이어의 위치가 결정된 후에 카메라의 위치 설정
        Debug.Log("LateUpdate");
    }

    private void FixedUpdate()
    {
        // 유니티의 물리설정 단위시간마다 호출 (기본 1초에 50번)
        // Update와 다르게 프레임당 연산과 단위시간이 일정
        // 단, 게임로직 등, 연산이 많은 작업을 FixedUpdate에 구현하지 않아야 함

        // 역할 : 성능과 프레임 드랍에 영향을 받지 않아야 하는 작업
        // ex) 물리적 처리
        Debug.Log("FixedUpdate");
    }


    private void OnDestroy()
    {
        
        // 스크립트가 삭제되었을 경우 호출
        // 존재자체가 사라질때 호출

        // 역할 : 스크립트의 마무리 진행
        Debug.Log("OnDestory");
    }
}
