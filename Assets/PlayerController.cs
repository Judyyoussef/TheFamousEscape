using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Other player-related code...

public GameObject Gun;
private bool hasGun = false;
    public void CollectGun()
    {
        hasGun = true;
        // Implement logic for what happens when the player collects the gun
        Debug.Log("Player collected the gun!");

        // You might want to enable a gun for the player or perform other actions here
    }
}