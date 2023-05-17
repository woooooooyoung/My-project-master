using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class UnityInput : MonoBehaviour
{
    /************************************************************************
     * 유니티 입력
     * 
     * 유니티에서 사용자의 명령을 감지할 수 있는 수단
     * 사용자는 외부 장치를 이용하여 게임을 제어할 수 있음
     * 유니티는 다양한 타입의 입력기기(키보드 및 마우스, 조이스틱, 터치스크린 등)를 지원
     ************************************************************************/
    private void Update()
    {
        InputByDevice();
    }
    private void InputByDevice()
    {
        // 키보드 입력
        if (Input.GetKeyUp(KeyCode.Space))        // Up : 키를 떼는 순간
            Debug.Log("Key Up");
        if (Input.GetKeyDown(KeyCode.Space))      // Down : 누르는 순간
            Debug.Log("Key Down");
        if (Input.GetKey(KeyCode.Space))          // 누르고 있는 중
            Debug.Log("Kwy pressing");

        // 마우스의 입력감지
        // 왼쪽버튼 0, 오른쪽버튼 1, 가운데(휠)버튼 2
        if (Input.GetMouseButton(0))
            Debug.Log("Mouse Left button pressing");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("Mouse Left button Up");
        if (Input.GetMouseButtonDown(0))
            Debug.Log("Mouse Left button Down");

    }

    // <InputManager>
    // 여러 장치의 입력을 입력매니저에 이름과 입력을 정의
    // 입력매니저의 이름으로 정의한 입력의 변경사항을 확인
    // 유니티 에디터의 Edit -> Project Settings -> Input Manager 에서 관리
    private void InputByInputManager()
    {
        // 버튼 입력
        // Fire1 : 키보드(Left Ctrl), 마우스(Left Button), 조이스틱(button0)으로 정의됨
        if (Input.GetButton("Fire1"))
            Debug.Log("Fire1 is pressing");
        if (Input.GetButtonDown("Fire1"))
            Debug.Log("Fire1 is down");
        if (Input.GetButtonUp("Fire1"))
            Debug.Log("Fire1 is up");

        // 축 입력
        // 축으로하면 데드값이라해서 슬그머니 움직임
        // Horizontal(수평) : 키보드(a,d / ←, →), 조이스틱(왼쪽 아날로그스틱 좌우)
        float x = Input.GetAxis("Horizontal");
        // Vertical(수직) : 키보드(w,s / ↑, ↓), 조이스틱(왼쪽 아날로그스틱 상하)
        float y = Input.GetAxis("Vertical");

        Debug.Log($"{x} , {y}");
    }

    // <InputSystem>
    // Unity 2019.1 부터 지원하게 된 입력방식
    // 컴포넌트를 통해 입력의 변경사항을 확인
    // GamePad, JoyStick, Mouse, Keyboard, Pointer, Pen, TouchScreen, XR 기기 등을 지원

    //Value : 특정한 값을 받음
    //        Add binding(기본바인딩)을 Value는 못받음
    //Button : 누르고 있는 중 떼는 중 전부 다 받음
    //Pass Through : 입력한걸 그대로 싹 다 받음
    private void InputByInputSystem()
    {
        // InputSystem은 코드로 구현을 안함
        // InputSystem은 이벤트 방식으로 구현됨
        // Update마다 입력변경사항을 확인하는 방식 대신 변경이 있을 경우 이벤트로 확인
        // 메시지를 통해 받는 방식과 이벤트 함수를 직접 연결하는 방식 등으로 구성
    }
    private void OnMove(InputValue value)
    {
        // Move 입력에 반응하는 OnMove 메시지 함수
        Vector2 dir = value.Get<Vector2>();
    }

    private void OnJump(InputValue value)
    {
        bool isPress = value.isPressed;
    }


}
