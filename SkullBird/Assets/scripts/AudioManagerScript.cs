using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManagerScript : MonoBehaviour
{

    public AudioData[] audios;

    [HideInInspector]
    public static AudioManagerScript __instance;

    
    void Awake()
    {
        // keep on diferent scenes
        DontDestroyOnLoad(gameObject);


        // force to exist only one instance
        if (__instance == null)
        {
            __instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        
        // create audio source for each audioData's
        foreach(var audioData in audios)
        {
            audioData.audioSource = gameObject.AddComponent<AudioSource>();
            audioData.audioSource.clip = audioData.audioClip;
            audioData.audioSource.loop = audioData.loop;
            audioData.audioSource.volume = audioData.volume;
            audioData.audioSource.pitch = audioData.pitch;
            audioData.audioSource.playOnAwake = false;
        }

    }

    private void Start()
    {
        PlayAudio("music");
    }

    public void PlayAudio(string audioName)
    {
        var audioData = Array.Find(audios, (item) => item.name == audioName);
        if(audioData == null)
        {
            Debug.LogWarning($"Audio name: {audioName} not found!");
            return;
        }

        audioData.audioSource.Play();
        
    }


}
