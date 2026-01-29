using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float fireRate = 12f;
    private float _nextFire;

    void Update()
    {
        if (!Input.GetMouseButton(0))
            return;

        if (Time.time < _nextFire)
            return;

        _nextFire = Time.time + 1f / fireRate;

        Instantiate(
            bulletPrefab,
            firePoint.position,
            firePoint.rotation
        );
    }
}
