using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Link : https://www.youtube.com/watch?v=rdX7nhH6jdM&t=71s

public class AudioManager : MonoBehaviour
{
    [SerializeField] public Sound[] sfxSoundA;
    [SerializeField] public AudioSource sfxSource;
                     
    [SerializeField] public Sound[] musicSoundA;
    [SerializeField] public AudioSource musicSource;

    public void PlaySFX(string name)
    {
        Sound mySound = Array.Find(musicSoundA, x => x.name == name);  // Lambda ( Condition )
                                                                       // 

        if(mySound == null)
        {
            Debug.Log("Kein Sound vorhanden");
        }
        else
        {
           // sfxSource.PlayOneShot(mySound);
        }

    }
}
