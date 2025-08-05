using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ColletSystem : MonoBehaviour
{
    [SerializeField] public Text collectTxt;
    
    public int Sankofa;
    
    void Start()
    {
        Sankofa = 0;
    }

    public void Update()
    {
        collectTxt.text = Sankofa.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Sankofa++;
        }
            
    }
}
