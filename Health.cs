using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 1;
    public bool IsAlive;
    [SerializeField] private Text HealthUI;

    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        IsAlive = true;
        currentHealth = maxHealth;
    }

    private void FixedUpdate()
    {
        HealthUI.text = currentHealth.ToString("");
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            IsAlive = false;
            anim.Play("Death");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            { 
                TakeDamage(1);
            }
        }
    }
}
