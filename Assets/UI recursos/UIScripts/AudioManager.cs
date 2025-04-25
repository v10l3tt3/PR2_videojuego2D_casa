using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip bandaSonora;
    public AudioClip fxButton;
    public AudioClip fxCoin;
    public AudioClip fxFire;
    public AudioClip fxDead;
    
    AudioSource gestorAudio;

    void Start()
    {
        gestorAudio = this.GetComponent<AudioSource>();
        gestorAudio.clip = bandaSonora;
        gestorAudio.loop = true;
        gestorAudio.Play();
    }

    void Update()
    {
        
    }
}
