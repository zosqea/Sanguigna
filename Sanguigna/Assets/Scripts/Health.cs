using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public int health;
    public int maxHealth;
    public int coefficient;
    void Start()
    {
        StartCoroutine("recoveryHealth");
    }
    private void Update()
    {
        //Debug.Log(health);
    }
    IEnumerator recoveryHealth()
    {
        while (true)
        {
            health+=1*coefficient;
            yield return new WaitForSeconds(1);
        }
    }
    public void takeHealth(int damage)
    {
        health = health - damage;
    }
}
