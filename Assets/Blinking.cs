using UnityEngine;

public class Blinking : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;
    void Update()
    {
        spriteRenderer.enabled = !spriteRenderer.enabled;
    }
}
