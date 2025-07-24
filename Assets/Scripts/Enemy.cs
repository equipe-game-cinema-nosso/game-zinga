using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Variaveis")]
    [SerializeField] private float speed;
    [SerializeField] private float rotation = 0;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
