using UnityEngine;

public class PlaySoundOnStartWithDelay : MonoBehaviour
{
    public AudioClip soundToPlay; // The audio clip you want to play
    private AudioSource audioSource;

    // Delay before playing the audio clip (in seconds)
    public float delayStart = 5f;
    public float delayFinal = 300f;
    private bool hasPlayedStart = false;
    private bool hasPlayedFinal = false;

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
        if (!hasPlayedStart && Time.time >= delayStart)
        {
            // Check if an audio clip is assigned and an AudioSource is present
            if (soundToPlay != null && audioSource != null)
            {
                // Play the assigned audio clip
                audioSource.PlayOneShot(soundToPlay);
                hasPlayedStart = true; // Mark that the audio has been played
            }
            else
            {
                Debug.LogError("No audio clip assigned or AudioSource missing.");
            }
        }
        // Check if the audio has not been played and the delay time has passed
        if (!hasPlayedFinal && Time.time >= delayFinal)
        {
            // Check if an audio clip is assigned and an AudioSource is present
            if (soundToPlay != null && audioSource != null)
            {
                // Play the assigned audio clip
                audioSource.PlayOneShot(soundToPlay);
                hasPlayedFinal = true; // Mark that the audio has been played
            }
            else
            {
                Debug.LogError("No audio clip assigned or AudioSource missing.");
            }
        }
    }
}
