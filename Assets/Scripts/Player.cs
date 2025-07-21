using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float speed;

    [SerializeField] private Vector2 pulo;




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

        }
        if (Input.GetKey(KeyCode.A))
        {
            this.gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("Tecla espaço");
            rb.AddForce(pulo, ForceMode2D.Impulse);
        }

    }
}
