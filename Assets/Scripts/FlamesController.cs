using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlamesController : MonoBehaviour
{
    public GameObject flame;

    // Update is called once per frame
    public void ChangeFlameState()
    {
        flame.SetActive(!flame.active);    
    }
}
