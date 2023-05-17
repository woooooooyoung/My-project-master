using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Events;
using UnityEngine;

public class UnityScript : MonoBehaviour
{
    /*********************************************************************************
     * 컴포넌트 (Component)
     * 
     * 특정한 기능을 수행할 수 있도록 구성한 작은 기능적 단위
     * 게임오브젝트의 작동과 관련한 부품
     * 게임오브젝트에 추가, 삭제하는 방식의 조립형 부품
     *********************************************************************************/

    /*********************************************************************************
     * MonoBehaviour
     * 
     * 컴포넌트를 기본클래스로 하는 클래스로 유니티 스크립트가 파생되는 기본 클래스
     * 게임 오브젝트에 스크립트를 컴포넌트로서 연결할 수 있는 구성을 제공
     * 스크립트 직렬화 기능, 유니티메시지 이벤트를 받는 기능, 코루틴 기능을 포함함
     * 컴포넌트가 쓸 수 있는 기능을 모두 가지고 있음
     * Component {Behaviour(MonoBehaviour)} 컴포넌트 안 비헤이베어 안에 모노비헤이비어가 있는 하위개념
     * 클래스에 MonoBehaviour가 붙어있지 않으면 게임오브젝트에 컴포넌트를 붙일 수 없음
     *********************************************************************************/
    // 파일이름과 클래스 이름이 동일하지 않으면 오류가 남, 유니티상에서 이름을 바꿧을 때 파일에서도 똑같이 바꿔줘야 함

    // <스크립트 직렬화 기능>
    // 인스펙터 창에서 컴포넌트의 맴버변수 값을 확인하거나 변경하는 기능
    // 컴포넌트의 값형식 데이터를 확인하거나 변경
    // 컴포넌트의 참조형식 데이터를 드래그 앤 드랍 방식으로 연결
    // 

    // public float value = 20;      // 초기값은 20으로 설정되고 따로 변경도 가능하다.
    // public float value;           // 기존에는 값을 정해줬지만 유니티에서는 스크립트 직렬화 기능이있어서 따로 정해주지 않아도 이렇게 써도 유니티 안에서 원하는데로 변경할 수 있다. 

    // <인스펙터창 직렬화가 가능한 자료형>
    [Header("C# Type")]
    public bool boolValue;       // 체크(true), 언체크(false)로 확인한다.
    public int intValue;         // 소수점이 아닌 정수만 사용.
    public float floatValue;     // 소수점까지 사용
    public string stringValue;   // 문자를 넣을 수 있다.
    // 그 외  기본 자료형

    // 기본 자료형의 선형자료구조
    public int[] array;          // 여러가지 크기의 배열을 가질 수 있다. 인스택터 창에서는 정해진 크리고 유지가 가능하다
    public List<int> list;       // 배열이랑 동일하게 여러가지 리스트를 가질 수 있다.
    // 이진탐색트리, 그래프, 딕셔너리는 힘들다

    [Header("Unity Type")]
    public Vector3 vector3;      // x, y, z의 축에 대한 값을 가짐(3차원게임에 쓰임)
    public Vector2 vector2;      // x, y의 축에 대한 값을 가짐(2차원게임에 쓰임)
                                 // 상황에 따라 2D게임인데 y축을 쓰는 경우가 있음 2D게임이라고 z축을 안쓰는게 아님
    public Color color;          // 색을 직렬화 함
    public LayerMask layerMask;  // 어떤것과 상호작용할지 정함 (플레이어와 물은 부딪혀라, 물과 ui는 부딪히지 마라 등)
    public AnimationCurve curve; // 예를 들어 점점 증가하는 형태로 진행하거나, 일자로 증가하는 형태로 진행하거나, 중간에 커브를 넣어서 진행하거나 (플레이어가 발사한 파이어볼의 크기가 점점 줄어들어 최대사거리에 닿을떄 사라져야 할때, 시간이 지날수록 사그라 드는 모닥불...)
    public Gradient gradient;    // 점점 색이 바뀜(체력바의 경우를 생각하면 됨)

    // [Serializable] 직렬화를 하려는 스크립트에 붙여줘야 함, 없으면 직렬화가 안됨

    [Header("Unity GameObject")]
    public GameObject obj;           // 참조도 직렬화가 가능함 (카메라를 넣을수도 있고 몬스터가 플레이어를 따라가게 하고 싶으면 참조에 Player을 넣으면 그 몬스터는 플레이어를 따라감) 

    [Header("Unity Component")]
    public new Transform transform;  //
    public new Rigidbody rigidbody;  // 누가 들고있는 Rigidbody를 참조할수도 있음 (특정버튼을 누르면 점프뛰게 만들수도있음)
    public new Collider collider;    //
    // 컴포넌트들 또한 참조가 가능하다.

    [Header("Unity Event")]
    public UnityEvent OnEvent;       // 어떤 오브젝트가 무슨반응을 할건지 끌어다가 붙여서 선택해서 사용 가능하다.(UI때 자세히 다룰것)
    // public UnityAction            // 유니티용 딜리게이트
    // public Action<int>            // C#용 딜리게이트
    // CallBack방식을 구현하기 위한 이벤트도 직렬화가 가능하다.

    // <어트리뷰트>
    // 클래스, 프로퍼티 또는 함수 위에 명시하여 특별한 동작을 나타낼 수 있는 마커

    [Space(30)]                     // 공간을 30만큼 떨어뜨림

    [Header("Unity Attribute")]     // 제목달아주기
    [SerializeField]                // private지만 인스펙터 창에서 보이게 함
    private int privateValue;
    [HideInInspector]               // public지만 가리거나 보여주고싶지 않을 때 
    public int publicValue;

    [Range(0, 10)]                  // 범위지정(0~10 사이의 값을 정하는 슬라이드 바가 생김)
    public float rangeValue;

    [TextArea(3, 5)]                // 여러줄의 텍스트 사용
    public string textField;

}
