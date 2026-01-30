using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public int maxAlive = 10;
    public float radius = 8f;

    private float lastSpawn;
    private int alive;

    private void Update()
    {
        if (Time.time - lastSpawn >= spawnInterval && alive < maxAlive)
        {
            Spawn();
            lastSpawn = Time.time;
        }
    }

    private void Spawn()
    {
        Vector2 offset = Random.insideUnitCircle * radius;
        Vector3 pos = transform.position + new Vector3(offset.x, offset.y, 0f);

        var enemy = Instantiate(enemyPrefab, pos, Quaternion.identity);
        alive++;

        // Khi enemy chết -> giảm alive
        enemy.AddComponent<OnDestroyCallback>().onDestroyed = () => alive--;
    }

    // helper: gọi callback khi object bị destroy
    private class OnDestroyCallback : MonoBehaviour
    {
        public System.Action onDestroyed;
        private void OnDestroy() => onDestroyed?.Invoke();
    }
}
