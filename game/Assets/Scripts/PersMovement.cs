using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float inputY = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;

        rb.velocity = new Vector2(inputX, inputY);
    }
}
