using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacter : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
            //rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y*(float)0.1);
            //rb.gravityScale *= -1;
        }
    }
}
