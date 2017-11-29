using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
[RequireComponent(typeof(AudioSource))]
public class SelfDestructAfterEffects : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    public IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(
            Mathf.Max(
                GetComponent<ParticleSystem>().main.duration,
                GetComponent<AudioSource>().clip.length
            )
        );
        Destroy(gameObject);
    }
}
