using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    [Tooltip("Assign the 'CameraPosition' Object of the Player!")] public Transform cameraPosition;

    void Update()
    {
        // SET THE CAMERA POSITION TO THE POSITION OF THE 'CAMERAPOSITION' OBJECT
        transform.position = cameraPosition.position;
    }
}
