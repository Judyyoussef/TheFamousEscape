using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RelicsManager : MonoBehaviour
{
    public DoorAnimationController doorAnimationController;
    bool isFirstRelicIn = false;
    bool isSecondRelicIn = false;
    bool isThirdRelicIn = false;
    bool isForthRelicIn = false;

    public void SetFirstRelic(Collider other)
    {
        isFirstRelicIn = true;
        TryOpenDoor(other);
    }

    public void SetSecondRelic(Collider other)
    {
        isSecondRelicIn = true;
        TryOpenDoor(other);
    }

    public void SetThirdRelic(Collider other)
    {
        isThirdRelicIn = true;
        TryOpenDoor(other);
    }

    public void SetForthRelic(Collider other)
    {
        isForthRelicIn = true;
        TryOpenDoor(other);
    }

    private void TryOpenDoor(Collider other)
    {
        if (isFirstRelicIn && isSecondRelicIn && isThirdRelicIn && isForthRelicIn)
        {
            doorAnimationController.OpenDoor();

            // Check if the colliding object has the specified tag
            if (other.CompareTag("PlayerDestination"))
            {
                Debug.Log("PlayerDestination found!");
                // Transition to the next scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}


