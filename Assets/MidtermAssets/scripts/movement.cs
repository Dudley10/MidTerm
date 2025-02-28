using UnityEngine;
using System.Collections;
public class movement : MonoBehaviour
{
    public Vector2 newPosition;
    public Vector3 mousePosG;
    Camera cam;
    Rigidbody2D body;
    public float start;
    public float baseSpeed = 2.0f;
    //public float maxY;
    //public float minY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition = Vector2.MoveTowards(body.position, mousePosG, baseSpeed * Time.fixedDeltaTime);
        body.position = newPosition;
    }
    //void limit(){
    //border = setBounds(MinY, maxY);
    //}
}
