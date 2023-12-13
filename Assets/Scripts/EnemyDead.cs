using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collider belongs to the XR Rig
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
