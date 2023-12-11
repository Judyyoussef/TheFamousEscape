using UnityEngine;

public class GunCollector : MonoBehaviour

{
            private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.CollectGun();

                // Optionally, you might want to play a sound or show an effect for key collection
                // For example: AudioManager.PlaySound("KeyCollected");
            }

            Destroy(gameObject);
        }
    }
    }

