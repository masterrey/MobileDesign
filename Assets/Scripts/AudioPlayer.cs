using TMPro;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;
    public int soundIndex = 0;
    public TMP_InputField inputField;

    private void Start()
    {
        inputField.text = audioClips[soundIndex].name;
    }
    public void Next()
    {
        if(soundIndex < audioClips.Length-1)
            soundIndex++;

        inputField.text = audioClips[soundIndex].name;
    }
    public void Prev()
    {
        if (soundIndex > 0)
            soundIndex--;
        inputField.text = audioClips[soundIndex].name;
    }
    public void PlaySound()
    {
        audioSource.clip = audioClips[soundIndex];
        audioSource.Play();
    }

    public void PlaySound(int soundIndex)
    {
        audioSource.clip = audioClips[soundIndex];
        audioSource.Play();
    }
}
