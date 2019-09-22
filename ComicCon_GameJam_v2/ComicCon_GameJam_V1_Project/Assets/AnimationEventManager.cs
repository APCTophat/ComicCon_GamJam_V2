using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventManager : MonoBehaviour
{
    public GameObject DustParticleSystem;

    public Transform SpawnPoints;

    public void CreateParticleEvent()
    {
        GameObject InstanciatePrefab = Instantiate(DustParticleSystem, SpawnPoints.position, Quaternion.Euler(-90,0,0));
        Destroy(InstanciatePrefab, 1f);
       
    }
}
