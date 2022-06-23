using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class RecipeChecker : MonoBehaviour
{
    public List<XRSocketInteractor> sockets = new List<XRSocketInteractor>();
    public List<GameObject> objects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        string currentName;
        string correctName;

        for (int i = 0; i < sockets.Count; i++)
        {
            currentName = sockets[i].GetOldestInteractableSelected().transform.name;
            correctName = objects[i].transform.name;

            if (currentName != correctName)
            {
                return;
            } 
        }

        // GetComponent<PanelOpener>().OpenPanel();
    }
}
