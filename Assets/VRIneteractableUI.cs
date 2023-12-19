using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRInteractableUI : MonoBehaviour
{
    private Renderer objectRenderer;
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        // Get the Renderer component
        objectRenderer = GetComponent<Renderer>();

        // Get or add XRGrabInteractable component
        grabInteractable = GetComponent<XRGrabInteractable>();
        if (grabInteractable == null)
        {
            grabInteractable = gameObject.AddComponent<XRGrabInteractable>();
        }

        // Set up the interaction events
        grabInteractable.onSelectEntered.AddListener(OnSelectEnter);
    }

    private void OnSelectEnter(XRBaseInteractor interactor)
    {
        // When selected (clicked), hide the object
        objectRenderer.enabled = false;
    }
}
