using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private RectTransform HPBar;
    private float originalWidth;
    public Health health;
    void Start()
    {
        health.onHealthChanged += UpdateHealthValue;
        originalWidth = HPBar.sizeDelta.x;
    }
    private void UpdateHealthValue()
    {
        float scale = (float)health.healthPoint / health.defaultHealthPoint;
        HPBar.sizeDelta = new Vector2(scale * originalWidth, HPBar.sizeDelta.y);
    }
}
