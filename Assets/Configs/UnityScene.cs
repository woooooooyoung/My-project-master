using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnityScene : MonoBehaviour
{
    /************************************************************************
         * �� (Scene)
         * 
         * ����Ƽ���� ���ӿ��带 �����ϴ� ����
         * ������Ʈ�� ���ϴ� ����ŭ ���� ������ �� ����
         * ���� ������ ������ ������ ������ ���� ������, ���� ���� ��ȯ�ϸ� ������ ���� �� ���� ����
         * ���� ���� �̿��Ͽ� ���� ���� ���ÿ� ���� ���� ���ӿ��忡�� ��뵵 ������
         ************************************************************************/

    // <���� ����>
    // ���� ���� ��ũ���� ��, ���� ���� �������� ���� ���Խ��Ѿ� �ش� ���� ��� ����
    // File - Build Settings - Scenes in Build

    // <�� �ε�>
    public void ChangeSceneByName(string sceneName)
    {
        //
        // SceneManager.LoadScene("ParkWooYoung", LoadSceneMode.Single);
        // "ParkWooYoung", LoadSceneMode.Single : ParkWooYoung�Ÿ� �ε��Ѵ�
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);

        // �ŸŴ����� ���ο� �źҷ�����
    }

    public void ChangeSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }

    // <�� �߰�>
    public void AddSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

    public void AddSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }

    // <�񵿱� �� �ε�>
    public void ChangeSceneASync(string sceneName)
    {
        // �񵿱� �� �ε� : ��׶���� ���� �ε��ϵ��� �Ͽ� ���� �� ������ ������ ��
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);

        asyncOperation.allowSceneActivation = true;     // �� �ε� �Ϸ�� �ٷ� �� �ε带 �����ϴ��� ����
        bool isLoad = asyncOperation.isDone;            // �� �ε��� �Ϸ�Ǿ����� �Ǵ�
        float progress = asyncOperation.progress;       // �� �ε��� Ȯ��
        asyncOperation.completed += (oper) => { };      // �� �ε� �Ϸ�� ������ �̺�Ʈ �߰�
    }

    // <Don't destroy on load>
    // ������ �ʴ� ������Ʈ���� ����, �����ϱ� ���� ��
    // ���� ��ȯ���� ���ŵ��� �ʱ� ���ϴ� ���ӿ�����Ʈ�� ��� �������� �ʴ� ���� ������Ʈ�� �߰��ϴ� ����� ���
    // (���� ����� ���� ���� ���� �ε�ÿ� ���ŵ��� �ʴ� ���� �����ϴ� ���)
    public void SetDontDestroyOnLoad(GameObject go)
    {
        DontDestroyOnLoad(go);
    }
}
