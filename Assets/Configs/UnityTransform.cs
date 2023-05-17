using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityTransform : MonoBehaviour
{
    /************************************************************************
	 * Ʈ������ (Transform)
	 * 
	 * ���ӿ�����Ʈ�� ��ġ, ȸ��, ũ�⸦ �����ϴ� ������Ʈ
	 * ���ӿ�����Ʈ�� �θ�-�ڽ� ���¸� �����ϴ� ������Ʈ
	 * ���ӿ�����Ʈ�� �ݵ�� �ϳ��� Ʈ������ ������Ʈ�� ������ ������ �߰� & ������ �� ����
	 ************************************************************************/

    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float rotateSpeed;
    // float moveSpeed = 3;
    // float rotateSpeed = 90;

    private void Start()
    {
        //TranslateMove();
    }

    // <Ʈ������ �̵�>
    // Translate : Ʈ�������� �̵� �Լ�
    private void TranslateMove()
    {

        // transform.position = new Vector3(10, 10, 10);
        // transform.localScale = new Vector3(3, 3, 3);
        // transform.rotation = new Vector3(90, 90, 90); Vector�δ� ȸ���� �־��� �� ����

        //// ���͸� �̿��� �̵�
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        //// x,y,z�� �̿��� �̵�
        //transform.Translate(0, 0, moveSpeed * Time.deltaTime);
    }

    // <Ʈ������ �̵� ����>
    private void TransformMoveSpace()
    {
        // ���带 �������� �̵�
        transform.Translate(1, 0, 0, Space.World);
        // ������ �������� �̵�
        transform.Translate(1, 0, 0, Space.Self);
        // �ٸ� ����� �������� �̵�
        transform.Translate(1, 0, 0, Camera.main.transform);
    }

    // <Ʈ������ ȸ��>
    // Rotate : Ʈ�������� ȸ�� �Լ�
    private void Rotate()
    {
        // ���� �̿��� ȸ�� (���� �������� �ð�������� ȸ��)
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        // ���Ϸ��� �̿��� ȸ��
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        // x,y,z�� �̿��� ȸ��
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }

    // <Ʈ������ ȸ�� ����>
    private void RotateSpace()
    {
        // ���带 �������� ȸ��
        transform.Rotate(1, 0, 0, Space.World);
        // ������ �������� ȸ��
        transform.Rotate(1, 0, 0, Space.Self);
        // ��ġ�� �������� ȸ��
        transform.RotateAround(Camera.main.transform.position, Vector3.up, 1);
    }

    // <Ʈ������ LookAt ȸ��>
    // LookAt : ��ġ�� �ٶ󺸴� �������� ȸ��
    private void LookAt()
    {
        // ��ġ�� �ٶ󺸴� ȸ��
        transform.LookAt(new Vector3(0, 0, 0));
        // �Ӹ��� ������ �߰��� �ٶ󺸴� ȸ��
        transform.LookAt(new Vector3(0, 0, 0), Vector3.right);
    }

    // <Quarternion & Euler>
    // Quarternion	: ����Ƽ�� ���ӿ�����Ʈ�� 3���� ������ �����ϰ� �̸� ���⿡�� �ٸ� ���������� ��� ȸ������ ����
    //				  �������� ȸ������ ������ ������ �߻����� ����
    // EulerAngle	: 3���� �������� ���������� ȸ����Ű�� ���
    //				  ������������ ������ ������ �߻��Ͽ� ȸ���� ��ġ�� ���� ���� �� ����
    // ������		: ���� �������� ������Ʈ�� �� ȸ�� ���� ��ġ�� ����, �� �׷����� �������� ������ϱ⶧���� �����Ϸ��� ���� ����
    //                ���� ���ļ� ����� ����

    // Quarternion�� ���� ȸ�������� ����ϴ� ���� ���������� �ʰ� �����ϱ� �����
    // ������ ��� ���ʹϾ� -> ���Ϸ����� -> �������� -> ������Ϸ����� -> ������ʹϾ� �� ���� ������ ��� ���ʹϾ��� �����
    private void Rotation()
    {
        // Ʈ�������� ȸ������ Euler���� ǥ���� �ƴ� Quaternion�� �����
        transform.rotation = Quaternion.identity;

        // Euler������ Quaternion���� ��ȯ
        transform.rotation = Quaternion.Euler(0, 90, 0);
        transform.rotation.ToEulerAngles(); 
    }

    // <Ʈ������ �θ�-�ڽ� ����>
    // Ʈ�������� �θ� Ʈ�������� ���� �� ����
    // �θ� Ʈ�������� �ִ� ��� �θ� Ʈ�������� ��ġ, ȸ��, ũ�� ������ ���� �����
    // �̸� �̿��Ͽ� ������ ������ �����ϴµ� ������ (ex. ���� �����̸�, �հ����� ���� ������)
    // ���̾��Ű â �󿡼� �巡�� & ����� ���� �θ�-�ڽ� ���¸� ������ �� ����
    private void TransformParent()
    {
        GameObject newGameObject = new GameObject() { name = "NewGameObject" };

        // �θ� ����
        transform.parent = newGameObject.transform;

        // �θ� ���������� Ʈ������
        // transform.localPosition	: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ��ġ
        // transform.localRotation	: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ȸ��
        // transform.localScale		: �θ�Ʈ�������� �ִ� ��� �θ� �������� �� ũ��

        // �θ� ����
        // �θ� Ʈ�������� ������ ���尡 �θ� ��
        transform.parent = null;

        // ���带 ���������� Ʈ������
        // transform.localPosition == transform.position	: �θ�Ʈ�������� ���� ��� ���带 �������� �� ��ġ
        // transform.localRotation == transform.rotation	: �θ�Ʈ�������� ���� ��� ���带 �������� �� ȸ��
        // transform.localScale								: �θ�Ʈ�������� ���� ��� ���带 �������� �� ũ��
    }
}
