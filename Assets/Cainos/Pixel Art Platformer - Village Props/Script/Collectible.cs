using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
    
       if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }

        //TODO send info to Player
        Inventiory playerInventory = null;

        playerInventory = collision.gameObject.GetComponent<Inventiory>();

        Destroy(gameObject);
    }
}
