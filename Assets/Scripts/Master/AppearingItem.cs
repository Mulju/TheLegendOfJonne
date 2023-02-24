using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearingItem : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private SpriteRenderer sp;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    // makes objects oppacity full, so player can see the object on trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            sp.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }

    // makes objects oppacity full, so player can see the object on collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            sp.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }
}
