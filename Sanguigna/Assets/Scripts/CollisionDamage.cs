using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public string tag;
    public int damage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == tag)
        {
            collision.gameObject.GetComponent<Health>().takeHealth(damage);
        }
    }
}
