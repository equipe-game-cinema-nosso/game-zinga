using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed = 6f;
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
        float moveHorizontal = Input.GetAxis("Horizontal");
        this.gameObject.transform.position += new Vector3(moveHorizontal * speed * Time.deltaTime, 0, 0);
      
    }
}
