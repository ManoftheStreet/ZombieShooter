using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoint = 100f;

    public void TakeDamage(float damage)
    {
        hitPoint -= damage;

        if(hitPoint < 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
