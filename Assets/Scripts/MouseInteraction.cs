using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    private void OnMouseDown()
    {
        ChestCode chestController = GetComponent<ChestCode>();
        if (chestController != null)
        {
            chestController.OpenChest();
        }
    }
}