using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class UnityBasic : MonoBehaviour
{
    /*
     * 자신의 게임 오브젝트를 가져옴
     * gameObject로 쓰는건 현재 자기한테 달라붙어있는 게임오브젝트를 의미함
     * public GameObject thisGameObject;
     * public void GameObjectBasic() { thisGameObject = gameObject; }
     */

    /*
     * 찾기
     * public GameObject player;
     * public void GameObjectBasic() { player = GameObject.Find("Player"); } 
     * public void GameObjectBasic() { player = GameObject.FindGameObjectWithTag("Player"); }
     */

    private void Start()
    {
        GameObjectBasic();
    }
    public void GameObjectBasic()
    {
        // <게임오브젝트 접근>
        // 컴포넌트가 붙어있는 게임오브젝트는 gameObject 속성을 이용하여 접근가능

        // 컴포넌트가 붙어있는 게임오브젝트
        // gameObject.name;            // 게임오브젝트의 이름접근
        // gameObject.name = "Player"; // 시작하자마자 이름을 Player로 바꿈
        // gameObject.active;          // 게임오브젝트의 활성화 여부 접근
        // gameObject.active = false;  // 시작하자마자 비활성화상태로 만듬
        // gameObject.tag;             // 게임오브젝트의 태그 접근
        // gameObject.layer;           // 게임오브젝트의 레이어 접근

        // 이름으로 찾기
        GameObject.Find("Player"); // Player의 이름을 가진 객체를 찾아냄, 이름이 같으면 제일먼저 찾은걸 가져오게 됨, 이름을 다 대조해야해서 느린방식임
        // 태그로 찾기
        GameObject.FindGameObjectWithTag("Player");  // Player이름을 가진 tag를 찾아냄
        GameObject.FindGameObjectsWithTag("Player"); // 여러개 찾기 

        // <게임오브젝트 생성>
        // 게임 도중에 만들 수 있음. 단, 게임도중에 만든거라 끄면 사라지고 키면 다시 생김
        // 이름을 안쓰면 그냥 기본 게임오브젝트 이름으로 됨
        GameObject newObject = new GameObject();    // 게임오브젝트 생성
        newObject.name = "New Game Object";         // 생성된 게임오브젝트에 이름부여
                                                    // GameObject newObject = new GameObject("New Game Object"); 이렇게 하면 만들자마자 이름도 같이 줌

        // <게임오브젝트 삭제>
        Destroy(gameObject);
        // GameObject obj = GameObject.Find("Player"); // 이름으로 찾기
        // Destroy(obj);                               // 삭제
        // Destroy(gameObject);                        // 현재 이 게임오브젝트가 붙어있는 객체 삭제 ex. 체력이 다된 몬스터 삭제
        // Destroy(gameObject, 5f);                       // 오버로딩으로 5초뒤 게임오브젝트가 붙어있는 객체 삭제, 지연삭제
        // Destroy(이름, 초);
    }
    public void ComponentBasic() // GameObjectBasic의 기본함수들 
    {
        // <게임오브젝트 접근>
        GetComponent<AudioSource>(); // 컴포넌트에서 GetComponent를 사용할 경우 부착되어 있는 게임오브젝트를 기준으로 접근\
        GetComponent<AudioSource>(); // 게임오브젝트의 컴포넌트 접근
        gameObject.GetComponent<AudioSource>(); // 게임오브젝트의 컴포넌트 접근
        gameObject.GetComponents<AudioSource>();    // 게임오브젝트의 여러 컴포넌트 접근

        GetComponentInChildren<AudioSource>();       // 자식게임오브젝트 포함 컴포넌트 접근
        GetComponentsInChildren<AudioSource>();      // 자식게임오브젝트 포함 여러 컴포넌트 접근
        gameObject.GetComponentInChildren<AudioSource>();   // 게임오브젝트의 자식게임오브젝트 포함 컴포넌트 접근
        gameObject.GetComponentsInChildren<AudioSource>();  // 게임오브젝트의 자식게임오브젝트 포함 여러 컴포넌트 접근

        GetComponent<AudioSource>();                 // 부모게임오브젝트 포함 컴포넌트 접근
        GetComponents<AudioSource>();                // 부모게임오브젝트 포함 여러 컴포넌트 접근
        gameObject.GetComponentInChildren<AudioSource>();   // 게임오브젝트의 부모게임오브젝트 포함 컴포넌트 접근
        gameObject.GetComponentsInChildren<AudioSource>();  // 게임오브젝트의 부모게임오브젝트 포함 여러 컴포넌트 접근

        // <컴포넌트 탐색>
        FindObjectOfType<AudioSource>();  // 씬 내의 컴포넌트 탐색
        FindObjectsOfType<AudioSource>(); // 씬 내의 모든 컴포넌트 탐색
                                          // FindObjectsOfType<Monster>();  // 씬 내의 모든 몬스터 탐색

        // <컴포넌트 추가> T
        // Rigidbody rigid = new Rigidbody();   // 가능하나 의미 없음, 컴포넌트는게임오브젝트에 부착되어 동작함에 의미가 있음
        gameObject.AddComponent<AudioSource>(); // 게임오브젝트에 컴포넌트 추가
        AudioSource source = gameObject.AddComponent<AudioSource>(); // 게임오브젝트에 컴포넌트 추가

        // <컴포넌트 삭제>
        Destroy(source);
        Destroy(GetComponent<Collider>());

    }
}
