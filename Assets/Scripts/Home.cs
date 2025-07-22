using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{

    public void SceneTarget(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

