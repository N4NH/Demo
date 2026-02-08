using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathHandler : MonoBehaviour
{
    public float restartDelay = 1.5f;

    // Được gọi từ PlayerHealth.SendMessage("OnPlayerDied")
    private void OnPlayerDied()
    {
        // tắt bắn (nếu script bạn tên PlayerShooting)
        var shooting = GetComponent<PlayerShooting>();
        if (shooting) shooting.enabled = false;

        // tắt render (ẩn player)
        var sr = GetComponent<SpriteRenderer>();
        if (sr) sr.enabled = false;

        Invoke(nameof(Restart), restartDelay);
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
