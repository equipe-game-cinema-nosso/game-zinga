using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float speed;

    [SerializeField] private Vector2 pulo;

    [SerializeField] private bool isChao;

    [SerializeField] private SpriteRenderer sprite;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         Move();
    }
    void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            sprite.flipX = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            sprite.flipX = true;
         }
        if (Input.GetKeyDown(KeyCode.Space) && isChao)
        {
            rb.AddForce(pulo, ForceMode2D.Impulse);
            isChao = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Plataforma")
        {
            Debug.Log("Colidi a plataforma");
            isChao = true;
        }
    }
}
