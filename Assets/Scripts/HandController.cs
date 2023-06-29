using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandController : MonoBehaviour
{
    public InputDeviceCharacteristics controllerCharacteristics;
    public GameObject handModel;
    public GameObject pointer;
    public InputDevice targetDevice;
    private Animator handAnimator; 

    void Start()
    {
        TryInitialize();
    }

    void TryInitialize()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }

        handAnimator = this.GetComponent<Animator>();

    }

    void Update()
    {
        if (!targetDevice.isValid)
        {
            TryInitialize();
        }
        else
        {
            // Trigger button
            if (targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
            {
                handAnimator.SetFloat("Trigger", triggerValue);
            }
            else
            {
                handAnimator.SetFloat("Trigger", 0);
            }

            // Grip button
            if (targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
            {
                handAnimator.SetFloat("Grip", gripValue);

                if (gripValue > 0.25 && pointer.active == false)
                {
                    pointer.SetActive(true);
                }
                if (gripValue <= 0.25 && pointer.active == true)
                {
                    pointer.SetActive(false);
                }
            }
            else
            {
                handAnimator.SetFloat("Grip", 0);
            }
        }
    }
}
