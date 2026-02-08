using UnityEngine;

public class EnemyChase2D : MonoBehaviour
{
    public float speed = 2.5f;
    private Transform player;

    private void Start()
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
        if (p) player = p.transform;
    }

    private void Update()
    {
        if (!player) return;

        Vector3 dir = (player.position - transform.position).normalized;
        transform.position += dir * speed * Time.deltaTime;
    }
}
