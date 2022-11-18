using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamSP : MonoBehaviour
{
    bool victory = false;

    public GameObject lowBeam;
    public GameObject highBeam;

    private void Start()
    {
        StartCoroutine(SpawnBeam());
    }

    IEnumerator SpawnBeam()
    {
        while (!victory)
        {
            InstantiateBeam();
            yield return new WaitForSeconds(Random.Range(1.5f, 3));
        }
        yield break;
    }

    private void InstantiateBeam()
    {
        if (CoinFlip())
        {
            GameObject lowTemp = Instantiate(lowBeam, gameObject.transform.position, lowBeam.transform.rotation);
        }
        else
        {
            Vector3 highBeamOffset = new Vector3(0, 1, 0);
            GameObject highTemp = Instantiate(highBeam, gameObject.transform.position, highBeam.transform.rotation);
            highTemp.transform.position += highBeamOffset;
        }
    }

    private bool CoinFlip() => Random.value < 0.5f ? true : false;
}
