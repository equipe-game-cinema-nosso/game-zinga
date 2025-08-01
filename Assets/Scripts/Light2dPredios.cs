using UnityEngine;
using UnityEngine.Rendering.Universal;

public class light2dPredios : MonoBehaviour
{
    public Light2D luz;
    public float intensidadeMin = 1.5f;
    public float intensidadeMax = 5f;
    public float velocidade = 10f;
    private bool aumentando = true;


        void Update()

    {
         if (aumentando)
            {
            luz.intensity += velocidade * Time.deltaTime;
            if (luz.intensity >= intensidadeMax)
                aumentando = false;
            }
            else
            {
                luz.intensity -= velocidade * Time.deltaTime;
                if (luz.intensity <= intensidadeMin)
                    aumentando = true;
            }
    }
}
