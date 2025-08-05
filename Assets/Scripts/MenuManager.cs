using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject Creditos;

    public void SceneTarget(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void AbrirCreditos()
    {
        Creditos.SetActive(true);
    }

    public void FecharCreditos()
    {
        Creditos.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Saiu");
    }
}

