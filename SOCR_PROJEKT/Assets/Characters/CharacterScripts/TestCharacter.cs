using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacter : MonoBehaviour
{
    private Rigidbody2D rb;
    int i;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rb.velocity.x, 10.0f*i);
        i = -1;
    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, 10.0f*i);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            i*=(-1);
        }
    }
}
