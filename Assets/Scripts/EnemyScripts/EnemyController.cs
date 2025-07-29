using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float lastSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        //---------aqui fica a detecção constante do player------------
        //caso sim, utilizar a função StopCoroutine para normalizar.
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyCollider")
        {
            StartCoroutine(DetectionRoutine());
        }
    }

    IEnumerator DetectionRoutine()
    {
        lastSpeed = speed;
        speed = 0;
        Debug.Log("Iniciando detecção"); //animação toca a partir daqui

        // Pausa por 2 segundos
        yield return new WaitForSeconds(2f);

        Debug.Log("Não identifiquei ninguém"); //animação encerra aqui

        // Pausa até o final do frame atual
        yield return new WaitForSeconds(0.5f);

        Debug.Log("Volto a funcionar normalmente");

        speed = lastSpeed;
        speed *= -1; // sprite flipado após ou antes dessa instrução
    }
}
