using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : MonoBehaviour
{
    Vector2 ArrowPosition;
    Vector2 ColisorPosition;
    public Transform colisor;
    public float speed = 15f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ArrowPosition = new Vector3(transform.position.x, transform.position.y);
        ColisorPosition = new Vector3(colisor.transform.position.x, colisor.position.y);
        transform.position = Vector2.MoveTowards(transform.position, colisor.position, speed);

        transform.

    }
}
