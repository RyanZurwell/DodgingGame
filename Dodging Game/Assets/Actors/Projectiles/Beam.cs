using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam : MonoBehaviour
{
    //A beam that comes towards the player from in front of the player.
    //The beam should choose if its a high beam or a low beam and adjust its color depending on the choice.
    //The beam should spawn x units in front of the player.
    //When the player hits the beam, the player will lose x health.

    private void Update()
    {
        Travel();

        CheckPosition();
    }

    private void Travel()
    {
        transform.Translate(Vector3.back * Time.deltaTime * 5, Space.World);
    }

    private void CheckPosition()
    {
        if (gameObject.transform.position.z > 0) return;

        Destroy(gameObject);
    }
}
