using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollector: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ChestController chestController = FindObjectOfType<ChestController>();

            if (chestController != null)
            {
                chestController.CollectKey();

                // Optionally, you might want to play a sound or show an effect for key collection
                // For example: AudioManager.PlaySound("KeyCollected");
            }

            Destroy(gameObject);
        }
    }
}
