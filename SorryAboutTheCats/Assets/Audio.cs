using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{


    float slider;
    public AudioMixer mixer;
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
        slider = GetComponent<Slider>().value;
        mixer.SetFloat("musicVol", slider);
    }
}