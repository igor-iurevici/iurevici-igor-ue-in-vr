using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypressSoundTrigger : MonoBehaviour
{
    public List<AudioSource> audioSources;
    private int currentlyPlayingIndex = -1;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < audioSources.Count; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                if (i < audioSources.Count && audioSources[i] != null)
                {
                    if (currentlyPlayingIndex != i)
                    {
                        // Stop the currently playing audio source, if any
                        if (currentlyPlayingIndex != -1)
                        {
                            audioSources[currentlyPlayingIndex].Stop();
                        }

                        audioSources[i].Play();
                        currentlyPlayingIndex = i;
                    }
                }
                else
                {
                    audioSources[currentlyPlayingIndex].Stop(); 
		        }
            }
        }
    }
}
