using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 10;
    [HideInInspector] public int healthPoint;
  
    public System.Action onHealthChanged;
    public System.Action onDead;

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1);
        Destroy(gameObject);
        onDead?.Invoke();
    }
    private void Start()
    { 
        healthPoint = defaultHealthPoint;
    }
    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;
        healthPoint -= damage;
        onHealthChanged?.Invoke();
        if (healthPoint <= 0) Die();
    } 
}
