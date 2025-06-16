using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pkayer_health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float health = 100;

    [SerializeField] private TextMeshProUGUI healthText;

    [SerializeField] private Transform spawnPoint;

    public bool isDead = false;
    private Inventiory inventory;

    private Animator animator;



    private void Start()
    {
        UpdateHealthText();

        inventory = GetComponent<Inventiory>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (transform.position.y < -6f)
        {
            Invoke(nameof(Respawn), 2f);
        }
    }


    public void TakeDamage(float damage)
    {
        health = health - damage;
        if (health < 0)
        {
            health = 0;
        }
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        if (health == 0)
        {
            isDead = true;
            animator.SetBool("isDead", true);
            Invoke(nameof(Respawn), 5f);
        }

        UpdateHealthText();
    }

    private void UpdateHealthText()
    {
        healthText.text = "zdrowie: " + health.ToString("0");
    }

    private void Respawn()
    {
        health = maxHealth;
        UpdateHealthText();

        inventory.ResetCollectibles();

        transform.position = spawnPoint.position;

        animator.SetBool("isDead", false);

        isDead = false;
    }

}
