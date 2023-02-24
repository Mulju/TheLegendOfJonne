using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedFallingPlatform : MonoBehaviour
{
    private Rigidbody2D rb;
    private CapsuleCollider2D coll;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<CapsuleCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Starts a 0.5 second timer when player collides with a falling platrom, then TriggerPlatform() makes platform to fall.
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(TriggerPlatform(0.5F));
        }
        // Makes falling platform inactive when it collides with a trap.
        if (collision.gameObject.CompareTag("Trap"))
        {
            gameObject.SetActive(false);
        }
    }

     // Changes falling platform physics to dynamic making it to fall.
     IEnumerator TriggerPlatform(float waitTime)
     {
        yield return new WaitForSeconds(waitTime);
        rb.bodyType = RigidbodyType2D.Dynamic;
     }
}