using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //private void Awake()
    //{
    //    ChangeSceneByName(0);
    //    Debug.Log("11");
    //}
    // private void OnEnable()
    // {
    //     ChangeSceneByName(0);
    // }
    public void SceneNumb(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
    }

}
