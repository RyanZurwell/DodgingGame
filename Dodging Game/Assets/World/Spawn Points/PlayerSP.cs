using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSP : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        SpawnPlayer();
    }

    private void SpawnPlayer()
    {
        GameObject playerTemp = Instantiate(player);
        playerTemp.name = "Player";
        playerTemp.transform.position = new Vector3(0, 1, 0);
    }
}
