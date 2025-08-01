using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    public void SceneTarget(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

