using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class LevelController : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            NextLevel();
        }
    }
    void NextLevel()
    {
        SceneManager.LoadScene("Home");

    }
}

