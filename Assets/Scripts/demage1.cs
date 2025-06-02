using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demage1 : MonoBehaviour
{
    public float damage = 40;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        Pkayer_health health = collision.gameObject.GetComponent<Pkayer_health>();
        if (health == null)

        {
            return;
        }

        health.TakeDamage(damage);



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            return;
        }
        Pkayer_health health = collision.gameObject.GetComponent<Pkayer_health>();
        if (health == null)

        {
            return;
        }

        health.TakeDamage(damage);

    }
}

