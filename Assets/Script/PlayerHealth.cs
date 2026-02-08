using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHP = 10;
    public int currentHP;

    public bool isDead { get; private set; }

    private void Awake()
    {
        currentHP = maxHP;
        isDead = false;
    }

    public void TakeDamage(int dmg)
    {
        if (isDead) return;

        currentHP -= dmg;
        if (currentHP <= 0)
        {
            currentHP = 0;
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (isDead) return;
        currentHP = Mathf.Min(maxHP, currentHP + amount);
    }

    private void Die()
    {
        isDead = true;

        // Tắt collider để không ăn damage nữa
        var col = GetComponent<Collider2D>();
        if (col) col.enabled = false;

        // Nếu có rigidbody thì có thể đứng yên luôn
        var rb = GetComponent<Rigidbody2D>();
        if (rb) rb.velocity = Vector2.zero;


        // Gọi xử lý chết (animation/UI/restart) ở script khác nếu muốn
        SendMessage("OnPlayerDied", SendMessageOptions.DontRequireReceiver);
    }
}
