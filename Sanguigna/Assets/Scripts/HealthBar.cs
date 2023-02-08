using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBar;
    private float health;
    private float maxHealth;
    public void Update()
    {
        health = gameObject.GetComponent<Health>().health;
        maxHealth = gameObject.GetComponent<Health>().maxHealth;
        healthBar.fillAmount = health / maxHealth;
    }
}
