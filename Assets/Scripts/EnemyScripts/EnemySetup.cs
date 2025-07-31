using UnityEngine;

public class EnemySetup : MonoBehaviour
{
    private Vector3 positionArea;
    private Vector3 detectionArea = new Vector3(5, 1, 0);
    private float leftSide, rightSide;

    [Header("Referências")]
    [SerializeField] private GameObject leftObject;
    [SerializeField] private GameObject rightObject;

    [Header("Variáveis e Controles")]
    [SerializeField, Range(5f, 15f)] private float areaSize;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        detectionArea.x = areaSize;

        leftSide = (detectionArea.x / 2) * -1;
        rightSide = detectionArea.x / 2;
    }

    private void Start()
    {
        leftObject.transform.position = new Vector3(transform.position.x + leftSide, leftObject.transform.position.y, 0); // talvez precise normalizar o Z no futuro para funcionar com as camadas
        rightObject.transform.position = new Vector3(transform.position.x + rightSide, rightObject.transform.position.y, 0);// talvez precise normalizar o Z no futuro para funcionar com as camadas
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(new Vector3(transform.position.x + positionArea.x, transform.position.y + positionArea.y, transform.position.z + positionArea.z),
                                        new Vector3(areaSize, detectionArea.y, transform.position.z + detectionArea.z));

        Gizmos.color = new Color (0.5f, 0.5f, 0.5f, 0.2f);
        Gizmos.DrawCube(new Vector3(transform.position.x + positionArea.x, transform.position.y + positionArea.y, transform.position.z + positionArea.z),
                                    new Vector3(areaSize, detectionArea.y, transform.position.z + detectionArea.z));
    }
}
