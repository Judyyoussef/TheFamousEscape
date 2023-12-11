using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public Transform player;            // Reference to the player's transform
    public GameObject bulletPrefab;     // Prefab of the bullet
    public Transform firePoint;         // Point where the bullets will be spawned
    public float bulletSpeed = 5f;      // Speed of the bullets
    public float shootInterval = 2f;    // Time interval between shots

    private float nextShootTime = 0f;   // Time when the enemy can shoot again

    void Update()
    {
        // Check if it's time to shoot again
        if (Time.time >= nextShootTime)
        {
            // Calculate the direction towards the player
            Vector3 directionToPlayer = player.position - transform.position;

            // Rotate the enemy to face the player (optional)
            transform.LookAt(player);

            // Spawn a bullet
            Shoot(directionToPlayer.normalized);

            // Set the next time the enemy can shoot
            nextShootTime = Time.time + shootInterval;
        }
    }

    void Shoot(Vector3 shootDirection)
    {
        // Instantiate a bullet at the firePoint position and rotation
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Get the Rigidbody component of the bullet
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();

        // Apply force to the bullet in the specified direction
        bulletRb.velocity = shootDirection * bulletSpeed;

        // Destroy the bullet after a certain time (adjust as needed)
        Destroy(bullet, 2f);
    }
}

