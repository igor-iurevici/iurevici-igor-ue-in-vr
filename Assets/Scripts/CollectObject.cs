using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CollectObject : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    private bool wasHeld = false;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectEntered.AddListener(OnGrab);
        grabInteractable.onSelectExited.AddListener(OnRelease);
    }

    private void OnGrab(XRBaseInteractor interactor)
    {
        wasHeld = true;
    }

    private void OnRelease(XRBaseInteractor interactor)
    {
        if (wasHeld)
        {
            // Object was previously held and is now released
            if (IsColliding())
            {
                // Object is colliding with the backpack
                Destroy(gameObject);
            }
        }
        wasHeld = false;
    }

    private bool IsColliding()
    {
        Collider[] colliders = GetComponentsInChildren<Collider>();

        foreach (Collider collider in colliders)
        {
            if (collider.gameObject.CompareTag("backpack"))
            {
                return true;
            }
        }

        return false;
    }
}
