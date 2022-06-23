using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrameMaterialSwapper : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    public List<Material> screenMats = new List<Material>();
    public List<Material> frameMats = new List<Material>();
    public float timeToSwap = 3;
    public float timer = 0;
    private int rnd = 0;
    private int prevRnd = -1;



    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            foreach(GameObject obj in objects)
            {
                if (obj.tag != "frame")
                {
                    while (rnd == prevRnd || rnd >= screenMats.Count)
                    {
                        rnd = Random.Range(0, screenMats.Count);
                    }
                    obj.GetComponent<MeshRenderer>().material = screenMats[rnd];
                    prevRnd = rnd;
                }
                else
                {
                    while (rnd == prevRnd || rnd >= frameMats.Count)
                    {
                        rnd = Random.Range(0, frameMats.Count);
                    }
                    obj.GetComponent<MeshRenderer>().material = frameMats[rnd];
                    prevRnd = rnd;
                }
            }

            timer = timeToSwap;
        }
    }
}
