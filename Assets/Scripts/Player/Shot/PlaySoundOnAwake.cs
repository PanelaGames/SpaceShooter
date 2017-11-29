using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlaySoundOnAwake : MonoBehaviour
{
    public void Awake()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }
}
