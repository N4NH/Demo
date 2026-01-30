using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHP = 3;
    private int hp;

    [Header("Death FX")]
    public GameObject explosionPrefab;
    public float fxLifeTime = 1f;

    private bool isDead = false;

    void Start()
    {
        hp = maxHP;
    }

    public void TakeDamage(int dmg)
    {
        if (isDead) return;   

        hp -= dmg;

        if (hp <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (isDead) return;  
        isDead = true;

        // ✅ tắt collider ngay lập tức
        GetComponent<Collider2D>().enabled = false;

        // ✅ tạo hiệu ứng nổ đúng 1 lần
        if (explosionPrefab != null)
        {
            GameObject fx = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(fx, fxLifeTime);
        }

        Destroy(gameObject);
    }
}
