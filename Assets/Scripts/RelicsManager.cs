using System;
using System.Collections;
using UnityEngine;


public class RelicsManager : MonoBehaviour
{
    public DoorAnimationController doorAnimationController;
    bool isFirstRelicIn = false;
    bool isSecondRelicIn = false;
    bool isThirdRelicIn = false;
    bool isForthRelicIn = false;


    public void SetFirstRelic()
    {
        isFirstRelicIn = true;
        TryOpenDoor();
    }

    public void SetSecondRelic()
    {
        isSecondRelicIn = true;
        TryOpenDoor();
    }

    public void SetThirdRelic()
    {
        isThirdRelicIn = true;
        TryOpenDoor();
    }

    public void SetForthRelic()
    {
        isForthRelicIn = true;
        TryOpenDoor();
    }



    private void TryOpenDoor()
    {
        if (isFirstRelicIn && isSecondRelicIn && isThirdRelicIn && isForthRelicIn )
        {
            doorAnimationController.OpenDoor();
        }
    }

}
