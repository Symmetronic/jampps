using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicController : MonoBehaviour
{
    AudioSource backgroundMusic;

    void Awake()
    {
        backgroundMusic = GetComponent<AudioSource>();
    }

    public void ToggleSound()
    {
        if (backgroundMusic.mute)
            backgroundMusic.mute = false;
        else
            backgroundMusic.mute = true;
    }
}