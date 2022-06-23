using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverAngleCheck : MonoBehaviour
{
    //public GameObject lever;
    public GameObject water;
    private bool open;

    // Start is called before the first frame update
    void Start()
    {
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Vector3.Angle(transform.forward, Vector3.forward));
        if (Vector3.Angle(transform.forward, Vector3.forward) <= 145.0)
        {
            open = true;
        }
        else
        {
            open = false;
        }
        water.SetActive(open);
    }
}
