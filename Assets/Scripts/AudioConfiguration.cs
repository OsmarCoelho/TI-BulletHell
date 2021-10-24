using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class AudioConfiguration : MonoBehaviour
{
    public AudioMixer mixer;  
    public Slider master, sfx, music; 

    void Start(){
        PlayerPrefs.GetFloat("MasterVolume", master.value);
        PlayerPrefs.GetFloat("MusicVolume", music.value);
        PlayerPrefs.GetFloat("SFXVolume", sfx.value);
    } 
    public void ChangeMasterVolume(){
        mixer.SetFloat("Master", master.value);
        PlayerPrefs.SetFloat("MasterVolume", master.value);
    }

    public void ChangeMusicVolume(){
        mixer.SetFloat("Music", music.value);
        PlayerPrefs.SetFloat("MusicVolume", music.value);
    }

    public void ChangeSFXVolume(){
        mixer.SetFloat("SFX", sfx.value);
        PlayerPrefs.SetFloat("SFXVolume", sfx.value);
    }
}
