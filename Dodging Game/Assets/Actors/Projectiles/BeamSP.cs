using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamSP : MonoBehaviour
{
    bool victory = false;

    private void Start()
    {
        StartCoroutine(SpawnBeam());
    }

    IEnumerator SpawnBeam()
    {
        while (!victory)
        {
            yield return new WaitForSeconds(Random.Range(1, 5));
        }
        yield break;
    }
}
