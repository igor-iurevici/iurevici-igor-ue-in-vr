using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CollectObject : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;
    private bool isColliding = false;
    private bool wasHeld = false;
    public AudioSource[] audioSource;

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
            if (isColliding)
            {
			    audioSource[Random.Range(0, audioSource.Length)].Play();
                // Object is colliding with the backpack
                Destroy(gameObject);
            }
        }
        wasHeld = false;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("backpack")) isColliding = true;
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("backpack")) isColliding = false;
    }
}
