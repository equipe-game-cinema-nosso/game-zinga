using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Saiu");
    }

}
