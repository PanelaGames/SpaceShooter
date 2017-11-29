using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnAwake : MonoBehaviour
{
    public GameObject audioSourcePrefab;
    public void Awake()
    {
        Instantiate(audioSourcePrefab, transform.position, transform.rotation);
    }
}
