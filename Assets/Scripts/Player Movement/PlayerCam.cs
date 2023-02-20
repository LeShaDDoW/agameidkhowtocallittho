using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    [Header("Sensitivity")]
    [Range(50, 800)] [Tooltip("Set both to the Same for Better Experience!")] public float sensX;
    [Range(50, 800)] [Tooltip("Set both to the Same for Better Experience!")] public float sensY;

    [Header("Assignables")]
    [Tooltip("Assign the 'Orientation' Object of the Player!")] public Transform orientation;

    float xRotation;
    float yRotation;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // GET MOUSE INPUT
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        // ADDING THE INPUT TO THE ROTATION
        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // ROTATING THE CAMERA
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
