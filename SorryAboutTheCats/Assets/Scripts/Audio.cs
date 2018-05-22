using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{



    public AudioMixer mixer;
    public void Slider(float slider)
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
        mixer.SetFloat("musicVol", slider);
    }
}