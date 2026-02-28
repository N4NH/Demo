using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01Shooting : MonoBehaviour
{
    [SerializeField] private Transform Maybay;
    public float offsetY;
    private Vector3 offset;
    public GameObject bulletPrefabs;
    public float shootingInterval;
    private float lastBulletTime;
    void Start()
    {
        if(offset==null)
        {
            offset = new Vector3(0, offsetY, 0);
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime >
            shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }
    private void ShootBullet()
    {      
        Instantiate(bulletPrefabs, Maybay.position + offset, Maybay.rotation);
    }
}
