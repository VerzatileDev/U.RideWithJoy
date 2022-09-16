using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeControl : MonoBehaviour {
    

    public AudioMixer volumeControl;
    

    public void SetVolume(float volume)
   {
        volumeControl.SetFloat("volume", volume);
       //Debug.Log(volume);
   }

    public void SetQuality (int qualityIndex)
   {
        QualitySettings.SetQualityLevel(qualityIndex);
   }

}


    

