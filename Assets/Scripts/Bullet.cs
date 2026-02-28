using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    public int damage;

    void Update()
    {
        transform.position += Vector3.up * flySpeed * Time.deltaTime;

        Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);

        if (viewPos.y > 1 || viewPos.y < 0 ||
            viewPos.x > 1 || viewPos.x < 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
