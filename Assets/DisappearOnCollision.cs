using UnityEngine;

public class DisappearOnCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the XR Rig
        if (other.CompareTag("Player"))
        {
            // Make the object disappear (e.g., disable its renderer or set it inactive)
            gameObject.SetActive(false);
        }
    }
}
