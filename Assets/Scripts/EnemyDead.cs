using UnityEngine;

public class EnemyDead : MonoBehaviour
{
    public Animator enemyAnimator;  // Reference to the Animator component

    // Offset to move the character down during the death animation
    public float deathYOffset = -0.5f;

    private void Start()
    {
        // Add the following line to get the Animator component
        enemyAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            // Play the die animation
            enemyAnimator.SetTrigger("Die");

            // Destroy the bullet
            Destroy(other.gameObject);

            // Delay the destruction of the enemy object to allow the death animation to play
            Destroy(gameObject, 10f);

            // Move the character down during the death animation
            StartCoroutine(MoveDownDuringDeath());
        }
    }

    // Coroutine to move the character down during the death animation
    private System.Collections.IEnumerator MoveDownDuringDeath()
    {
        // Wait for a short time before moving down (adjust the delay as needed)
        yield return new WaitForSeconds(0.5f);

        // Move the character down in the Y-axis during the death animation
        Vector3 newPosition = transform.position;
        newPosition.y += deathYOffset;
        transform.position = newPosition;
    }
}
