using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    public Animator enemyAnimator;  // Reference to the Animator component

    private void Start()
    {
        // Add the following line to get the Animator component
        enemyAnimator = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collider belongs to the XR Rig
        if (collision.gameObject.CompareTag("Bullet"))
        {
            enemyAnimator.SetTrigger("Die");
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
