using UnityEngine;

public class ZingaController : MonoBehaviour
{
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
        float horizontal = Input.GetAxis("Horizontal");
        transform.position = new Vector3(horizontal, 0, 0);
    }
}
