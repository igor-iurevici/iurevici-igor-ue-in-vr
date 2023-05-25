using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Collect : MonoBehaviour
{
    XRSocketInteractor socket;
    public AudioSource[] audioSource;

    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    public void CollectObj()
    {
        audioSource[Random.Range(0, audioSource.Length)].Play();
        //IXRSelectInteractable objName = socket.GetOldestInteractableSelected();
        XRGrabInteractable grabInteractable = socket.GetOldestInteractableSelected() as XRGrabInteractable;
        if (grabInteractable != null)
        {
            GameObject objectToDestroy = grabInteractable.gameObject;
            Destroy(objectToDestroy);
        }
    }
}
