using System.Collections;
using UnityEngine;


public class ChestController : MonoBehaviour
{
    private Animator chestAnimator;
    private bool hasKey = false;
    public GameObject Gun; // Reference to the gun object
    public float gunAppearanceDelay = 1.5f; // Adjust this value as needed

    private void Start()
    {
        chestAnimator = GetComponent<Animator>();
        if (Gun != null)
        {
            Gun.SetActive(false); // Deactivate the gun object initially
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (hasKey)
            {
                // Toggle the chest state
                bool isChestOpen = !chestAnimator.GetBool("Toggle");
                chestAnimator.SetBool("Toggle", isChestOpen);

                // Activate or deactivate the Gun object based on the chest state with a delay
                StartCoroutine(DelayedGunAppearance(isChestOpen));
            }
            else
            {
                Debug.Log("You need to collect the key first!");
            }
        }
    }

    // Call this method when the key is collected
    public void CollectKey()
    {
        hasKey = true;
        Debug.Log("Key collected!");
    }

    // Coroutine for delayed gun appearance
    private IEnumerator DelayedGunAppearance(bool isChestOpen)
    {
        yield return new WaitForSeconds(gunAppearanceDelay);

        if (Gun != null)
        {
            Gun.SetActive(isChestOpen);
        }
    }
}