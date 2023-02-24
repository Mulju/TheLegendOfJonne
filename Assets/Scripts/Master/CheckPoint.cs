using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private AudioSource checkpoint;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Changes spawn point to the latest Checkpoint Player has collided with. 
        if (collision.transform.tag == "Player")
        {
            checkpoint.Play();
            PlayerManager.lastCheckPointPos = transform.position;
        }
    }
}
