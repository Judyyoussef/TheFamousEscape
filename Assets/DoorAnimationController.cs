using UnityEngine;

public class DoorAnimationController : MonoBehaviour
{
    private Animator doorAnimator;
    private int collectedObjects = 0;
    public int objectsToCollect = 5; // Set the number of objects to collect
    private bool isOpen = false;

    private void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the tag "Objects," the door is not already open, and the required objects are not collected
        if (other.CompareTag("Objects") && !isOpen && collectedObjects < objectsToCollect)
        {
            // Increment the collected objects count
            collectedObjects++;

            // Check if the required number of objects is collected
            if (collectedObjects == objectsToCollect)
            {
                // Play the "Take 001" animation
                doorAnimator.SetTrigger("Take001");

                isOpen = true; // Set the flag to prevent multiple openings
            }
        }
    }
}
