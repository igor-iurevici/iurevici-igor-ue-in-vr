using UnityEngine;

public class PlaySoundOnStartWithDelay : MonoBehaviour
{
    public AudioClip soundToPlay; // The audio clip you want to play
    private AudioSource audioSource;

    // Delay before playing the audio clip (in seconds)
    public float delay = 5f;
    private bool hasPlayed = false;

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();

        // Check if an AudioSource is attached
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource found on this GameObject.");
        }
    }

    private void Update()
    {
        // Check if the audio has not been played and the delay time has passed
        if (!hasPlayed && Time.time >= delay)
        {
            // Check if an audio clip is assigned and an AudioSource is present
            if (soundToPlay != null && audioSource != null)
            {
                // Play the assigned audio clip
                audioSource.PlayOneShot(soundToPlay);
                hasPlayed = true; // Mark that the audio has been played
            }
            else
            {
                Debug.LogError("No audio clip assigned or AudioSource missing.");
            }
        }
    }
}
