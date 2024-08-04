using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class AudioData
{

    public string name;
    public AudioClip audioClip;

    public bool loop;

    [Range(0.1f, 1f)]
    public float volume;

    [Range(0.1f, 3f)]
    public float pitch;

    [HideInInspector]
    public AudioSource audioSource;
    
}
