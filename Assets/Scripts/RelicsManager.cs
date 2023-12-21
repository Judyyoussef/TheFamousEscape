using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RelicsManager : MonoBehaviour
{
    public DoorAnimationController doorAnimationController;

    int objectCounter = 0;

    public void SetFirstRelic()
    {
        objectCounter++;

        TryOpenDoor();
        Debug.Log("first in");

    }


    private void TryOpenDoor()
    {
        if (objectCounter>=4)
        {
            doorAnimationController.OpenDoor();

            // Check if the colliding object has the specified tag


            Debug.Log("PlayerDestination found!");
            // Transition to the next scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}


