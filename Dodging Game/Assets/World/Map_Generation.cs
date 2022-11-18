using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_Generation : MonoBehaviour
{
    public GameObject worldChunk;
    public GameObject worldChunkEnd;

    private void Start()
    {
        GenerateWorld();
    }

    private void GenerateWorld()
    {
        GenerateChunks(GetWorldSize());
        //Generate Wave Controllers
        //Spawn Player
    }

    private int GetWorldSize()
    {
        return 25;
    }

    private void GenerateChunks(int worldSize)
    {
        for (int i = 0; i < worldSize; i++)
        {
            if (i == worldSize - 1)
            {
                GameObject endChunkTemp = Instantiate(worldChunkEnd, gameObject.transform);
                endChunkTemp.name = "World Chunk (End)";
                endChunkTemp.transform.position = new Vector3(0, 0, i * 10);
                return;
            }

            GameObject chunkTemp = Instantiate(worldChunk, gameObject.transform);
            chunkTemp.name = "World Chunk";
            chunkTemp.transform.position = new Vector3(0, 0, i * 10);
        }
    }
}
