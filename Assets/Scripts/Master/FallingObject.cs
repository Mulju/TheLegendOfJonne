using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    private Rigidbody2D rb;
    private CapsuleCollider2D coll;
    private BoxCollider2D bColl;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<CapsuleCollider2D>();
        bColl = GetComponent<BoxCollider2D>();
    }

    // Object becomes dynamic on collision with player making it fall.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
        if (collision.gameObject.CompareTag("Trap"))
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            bColl.enabled = true;
        }
        
    }
}
