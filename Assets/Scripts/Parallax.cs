using UnityEngine;
using UnityEngine.UIElements;

public class Parallax : MonoBehaviour
{
    private float tamanho;
    private float PosInicial;
    private Transform cam;

    [SerializeField] private float ParallaxEfeito;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PosInicial = transform.position.x;
        tamanho = GetComponent<SpriteRenderer>().bounds.size.x;
        cam = Camera.main.transform;
            
    }

    // Update is called once per frame
    void Update()
    {
        float RePos = cam.transform.position.x * (1 - ParallaxEfeito);
        float Distancia = cam.transform.position.x * ParallaxEfeito;

        transform.position = new Vector3(PosInicial + Distancia, transform.position.y, transform.position.z);

        if (RePos > PosInicial + tamanho)
        {
            PosInicial += tamanho;
        }
        else if (RePos < PosInicial - tamanho)
        {
            PosInicial -= tamanho;
        }
    }
}
