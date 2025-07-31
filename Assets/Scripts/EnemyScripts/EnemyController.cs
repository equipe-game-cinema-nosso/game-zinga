using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spritePlayer;
    [SerializeField] private float speed;
    [SerializeField] private GameObject detectionObject;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource killSound;

    private float lastSpeed;

    public bool playerDetected;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    public void WhenPlayerWasDetected()
    {
        Debug.Log("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
        StartCoroutine(detectionAdjustment());
        //precisa de uma booleana (que pode ser playerDetected) que passa a informa��o pro player que ele "morreu".
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyCollider")
        {
            StartCoroutine(DetectionRoutine());
        }
    }

    IEnumerator detectionAdjustment()
    {
        playerDetected = true;

        yield return new WaitForSeconds(0.5f);
        
        StopCoroutine(DetectionRoutine());
        speed = 0;
        animator.SetTrigger("Detected"); //ativaria a anima��o para isso
        killSound.Play(); //tocaria um som do lazer
        //colocaria ela em uma posi��o para recome�ar
    }

    IEnumerator DetectionRoutine()
    {
        lastSpeed = speed;
        speed = 0;
        Debug.Log("Iniciando detec��o"); //anima��o toca a partir daqui

        // Pausa por 2 segundos
        yield return new WaitForSeconds(2f);

        Debug.Log("N�o identifiquei ningu�m"); //anima��o encerra aqui

        // Pausa at� o final do frame atual
        yield return new WaitForSeconds(0.5f);
        Debug.Log("Volto a funcionar normalmente");

        speed = lastSpeed;
        this.gameObject.transform.eulerAngles += new Vector3(0, 180, 0);
        speed *= -1; // sprite flipado ap�s ou antes dessa instru��o
    }
}
