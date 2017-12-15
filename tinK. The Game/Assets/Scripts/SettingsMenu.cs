using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour {

    public AudioMixer audioMixer;
    public AudioMixer audioSpraak;
    public AudioMixer audioEffect;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetVolumeDialoge(float volume)
    {
        audioSpraak.SetFloat("DialogeVol", volume);
    }

    public void SetVolumeEffecten(float volume)
    {
        audioEffect.SetFloat("SoundEffectsVol", volume);
    }
}
