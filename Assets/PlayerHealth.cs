using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] private GameObject GameOver_Panel;
    protected override void Die()
    {
        base.Die();
        GameOver_Panel.SetActive(true);
        Debug.Log("Player died");
    }
}
