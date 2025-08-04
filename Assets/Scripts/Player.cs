using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float speed;

    [SerializeField] private Vector2 pulo;

    [SerializeField] private bool isChao;

    [SerializeField] private SpriteRenderer sprite;

    [SerializeField] private Animator animator;

    [SerializeField] EnemyController enemyController;

    [SerializeField] public Vector2 Checkpoint;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!enemyController.playerDetected)
        {
            Move();
        }
        else
        {
            animator.SetBool("Detectada", true);
            StartCoroutine(checkpointReturn());

        }
       
    }

    IEnumerator checkpointReturn()
    {
        yield return new WaitForSeconds(3f);
        transform.position = Checkpoint;
        enemyController.playerDetected = false;
        animator.SetBool("Detectada", false);
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            sprite.flipX = false;
            animator.SetBool("Correndo", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            sprite.flipX = true;
            animator.SetBool("Correndo", true);
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Correndo", false);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isChao)
        {
            rb.AddForce(pulo, ForceMode2D.Impulse);
            isChao = false;
            animator.SetBool("NoChao", false);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Plataforma")
        {
            isChao = true;
            animator.SetBool("NoChao", true);
        }
    }
    
}

