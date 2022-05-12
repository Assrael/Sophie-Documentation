using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour 
{
    AudioSource sfx;
    public AudioClip[] soundCollection;
    public AudioClip music;

    public float Volume;

    // Start is called before the first frame update
    void Start()
    {
        sfx = GetComponent<AudioSource>();
        if (sfx == null) sfx = gameObject.AddComponent<AudioSource>();
        sfx.PlayOneShot(music,Volume);
    }

    public void AudioPlayer(int sound)
    {
        sfx.PlayOneShot(soundCollection[sound], Volume);
    }
}
