using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestructAfterParticleSystemDuration : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(SelfDestruct());
    }

    public IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(GetComponent<ParticleSystem>().main.duration);
        Destroy(gameObject);
    }
}
