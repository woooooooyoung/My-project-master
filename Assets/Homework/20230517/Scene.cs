using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnityScene : MonoBehaviour
{
    // <¾À ·Îµå>
    public void ChangeSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void ChangeSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }
    public void AddSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

    public void AddSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }
    public void ChangeSceneASync(string sceneName)
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);

        asyncOperation.allowSceneActivation = true;
        bool isLoad = asyncOperation.isDone;       
        float progress = asyncOperation.progress;  
        asyncOperation.completed += (oper) => { }; 
    }

    public void SetDontDestroyOnLoad(GameObject go)
    {
        DontDestroyOnLoad(go);
    }
}
