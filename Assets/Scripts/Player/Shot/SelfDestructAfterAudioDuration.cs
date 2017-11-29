using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SelfDestructAfterAudioDuration : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(SelfDestruct());
    }
    public IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        Destroy(gameObject);
    }
}
