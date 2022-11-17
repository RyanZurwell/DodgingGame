using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Vector3 playerPos;
    public Vector3 camOffset;

    private void Update()
    {
        playerPos = GetComponent<Cinemachine.CinemachineFreeLook>().LookAt.position;
        camOffset = new Vector3(0, 7, -8);
        gameObject.transform.position = playerPos + camOffset;
    }
}
