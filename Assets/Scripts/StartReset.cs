using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartReset : MonoBehaviour
{
    public List<GameObject> panelsToClose = new List<GameObject>();
    public List<GameObject> panelsToOpen = new List<GameObject>();

    void Awake()
    {
        if (panelsToClose != null)
        {
            foreach (GameObject panel in panelsToClose)
            {
                panel.SetActive(false);
            }
        }    
        if (panelsToOpen != null)
        {
            foreach (GameObject panel in panelsToOpen)
            {
                panel.SetActive(true);
            }
        }    
    }
}
