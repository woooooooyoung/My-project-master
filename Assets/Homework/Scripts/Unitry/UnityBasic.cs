using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class UnityBasic : MonoBehaviour
{
    /*
     * �ڽ��� ���� ������Ʈ�� ������
     * gameObject�� ���°� ���� �ڱ����� �޶�پ��ִ� ���ӿ�����Ʈ�� �ǹ���
     * public GameObject thisGameObject;
     * public void GameObjectBasic() { thisGameObject = gameObject; }
     */

    /*
     * ã��
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
        // <���ӿ�����Ʈ ����>
        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� gameObject �Ӽ��� �̿��Ͽ� ���ٰ���

        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ
        // gameObject.name;            // ���ӿ�����Ʈ�� �̸�����
        // gameObject.name = "Player"; // �������ڸ��� �̸��� Player�� �ٲ�
        // gameObject.active;          // ���ӿ�����Ʈ�� Ȱ��ȭ ���� ����
        // gameObject.active = false;  // �������ڸ��� ��Ȱ��ȭ���·� ����
        // gameObject.tag;             // ���ӿ�����Ʈ�� �±� ����
        // gameObject.layer;           // ���ӿ�����Ʈ�� ���̾� ����

        // �̸����� ã��
        GameObject.Find("Player"); // Player�� �̸��� ���� ��ü�� ã�Ƴ�, �̸��� ������ ���ϸ��� ã���� �������� ��, �̸��� �� �����ؾ��ؼ� ���������
        // �±׷� ã��
        GameObject.FindGameObjectWithTag("Player");  // Player�̸��� ���� tag�� ã�Ƴ�
        GameObject.FindGameObjectsWithTag("Player"); // ������ ã�� 

        // <���ӿ�����Ʈ ����>
        // ���� ���߿� ���� �� ����. ��, ���ӵ��߿� ����Ŷ� ���� ������� Ű�� �ٽ� ����
        // �̸��� �Ⱦ��� �׳� �⺻ ���ӿ�����Ʈ �̸����� ��
        GameObject newObject = new GameObject();    // ���ӿ�����Ʈ ����
        newObject.name = "New Game Object";         // ������ ���ӿ�����Ʈ�� �̸��ο�
                                                    // GameObject newObject = new GameObject("New Game Object"); �̷��� �ϸ� �����ڸ��� �̸��� ���� ��

        // <���ӿ�����Ʈ ����>
        Destroy(gameObject);
        // GameObject obj = GameObject.Find("Player"); // �̸����� ã��
        // Destroy(obj);                               // ����
        // Destroy(gameObject);                        // ���� �� ���ӿ�����Ʈ�� �پ��ִ� ��ü ���� ex. ü���� �ٵ� ���� ����
        // Destroy(gameObject, 5f);                       // �����ε����� 5�ʵ� ���ӿ�����Ʈ�� �پ��ִ� ��ü ����, ��������
        // Destroy(�̸�, ��);
    }
    public void ComponentBasic() // GameObjectBasic�� �⺻�Լ��� 
    {
        // <���ӿ�����Ʈ ����>
        GetComponent<AudioSource>(); // ������Ʈ���� GetComponent�� ����� ��� �����Ǿ� �ִ� ���ӿ�����Ʈ�� �������� ����\
        GetComponent<AudioSource>(); // ���ӿ�����Ʈ�� ������Ʈ ����
        gameObject.GetComponent<AudioSource>(); // ���ӿ�����Ʈ�� ������Ʈ ����
        gameObject.GetComponents<AudioSource>();    // ���ӿ�����Ʈ�� ���� ������Ʈ ����

        GetComponentInChildren<AudioSource>();       // �ڽİ��ӿ�����Ʈ ���� ������Ʈ ����
        GetComponentsInChildren<AudioSource>();      // �ڽİ��ӿ�����Ʈ ���� ���� ������Ʈ ����
        gameObject.GetComponentInChildren<AudioSource>();   // ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ ���� ������Ʈ ����
        gameObject.GetComponentsInChildren<AudioSource>();  // ���ӿ�����Ʈ�� �ڽİ��ӿ�����Ʈ ���� ���� ������Ʈ ����

        GetComponent<AudioSource>();                 // �θ���ӿ�����Ʈ ���� ������Ʈ ����
        GetComponents<AudioSource>();                // �θ���ӿ�����Ʈ ���� ���� ������Ʈ ����
        gameObject.GetComponentInChildren<AudioSource>();   // ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ ���� ������Ʈ ����
        gameObject.GetComponentsInChildren<AudioSource>();  // ���ӿ�����Ʈ�� �θ���ӿ�����Ʈ ���� ���� ������Ʈ ����

        // <������Ʈ Ž��>
        FindObjectOfType<AudioSource>();  // �� ���� ������Ʈ Ž��
        FindObjectsOfType<AudioSource>(); // �� ���� ��� ������Ʈ Ž��
                                          // FindObjectsOfType<Monster>();  // �� ���� ��� ���� Ž��

        // <������Ʈ �߰�> T
        // Rigidbody rigid = new Rigidbody();   // �����ϳ� �ǹ� ����, ������Ʈ�°��ӿ�����Ʈ�� �����Ǿ� �����Կ� �ǹ̰� ����
        gameObject.AddComponent<AudioSource>(); // ���ӿ�����Ʈ�� ������Ʈ �߰�
        AudioSource source = gameObject.AddComponent<AudioSource>(); // ���ӿ�����Ʈ�� ������Ʈ �߰�

        // <������Ʈ ����>
        Destroy(source);
        Destroy(GetComponent<Collider>());

    }
}
