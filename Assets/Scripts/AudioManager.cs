using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds; 
    public static AudioManager audioManager;

    void Awake() {

        if (audioManager == null) {
            audioManager = this;
        } else {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        foreach (Sound sound in sounds) {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.loop = sound.loop;
        }
    }

    void Start() {
        Play("Background Music");
    }

    public void Play(string name) {
        foreach (Sound sound in sounds) {
            if (String.Equals(sound.name, name)) {
                sound.source.Play();
            }
        }
    }

    public void Pause(string name) {
        foreach (Sound sound in sounds) {
            if (String.Equals(sound.name, name)) {
                sound.source.Pause();
            }
        }
    }

    public void UnPause(string name) {
        foreach (Sound sound in sounds) {
            if (String.Equals(sound.name, name)) {
                sound.source.UnPause();
            } 
        }
    }
}
