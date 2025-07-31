using UnityEngine;


public class Parallax : MonoBehaviour
{
    [Range(0f, 1.5f)] public float parallaxX;
    [Range(0f, 1.5f)] public float parallaxY;
    private Transform cam;

    Vector3 camPos; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (cam == null)
           cam = Camera.main.transform;
       
        if (cam != null) 
            camPos = cam.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (cam == null) return;

        Vector3 delta = cam.position - camPos;

        transform.position += new Vector3(delta.x * parallaxX, delta.y * parallaxY, 0f);

        camPos = cam.position;
    }
}
