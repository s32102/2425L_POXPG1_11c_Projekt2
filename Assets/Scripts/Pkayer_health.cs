using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pkayer_health : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] private float health = 100;

    [SerializeField] private TextMeshProUGUI healthText;

    public bool isDead = false;

    private void Start()
    {
        UpdateHealthText();
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
        }

        UpdateHealthText();
    }

    private void UpdateHealthText()
    {
        healthText.text = "zdrowie: " + health.ToString("0");
    }

}
