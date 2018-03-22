using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CarTarget : MonoBehaviour
{
    public float health = 50f;
    int score = 20;

    int coinValue = 10;
    // Use this for initialization
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    // Update is called once per frame
    void Die()
    {
        
        Destroy(gameObject);
    }
}
