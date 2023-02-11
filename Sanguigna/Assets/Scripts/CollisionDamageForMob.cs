using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamageForMob : MonoBehaviour
{
    public string tag;
    public int damage;
    
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            tag = "Dark";
            gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }
        else if(Input.GetKey(KeyCode.Alpha2))
        {
            tag = "White";
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
        else if (Input.GetKey(KeyCode.Alpha3))
        {
            tag = "Green";
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        else if (Input.GetKey(KeyCode.Alpha4))
        {
            tag = "Red";
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tag)
        {
            collision.gameObject.GetComponent<Health>().takeHealth(damage);
        }
    }
}
