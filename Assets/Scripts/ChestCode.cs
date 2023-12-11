using UnityEngine;

public class ChestCode : MonoBehaviour
{
    private Animator chestAnimator;

    private void Start()
    {
        // Get the Animator component
        chestAnimator = GetComponent<Animator>();
    }

    public void OpenChest()
    {
        // Trigger the "Open" animation
        chestAnimator.SetTrigger("Open");
    }
}
