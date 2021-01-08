using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds; 

    void Awake()
    {
        foreach (Sound sound in sounds) {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.loop = sound.loop;
        }
    }

    void Start() 
    {
        Play("Background Music");
    }

    public void Play(string name)
    {
        foreach (Sound sound in sounds) {
            if (String.Equals(sound.name, name)) {
                sound.source.Play();
            }
        }
    }
}
