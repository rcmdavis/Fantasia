using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRotating : MonoBehaviour
{
    public Transform target;            // The target to follow (usually the player character)
    public float rotationSpeed = 2.0f;  // Rotation speed with the mouse
    public Vector3 offset = new Vector3(0, 2, -5); // Camera offset from the target

    private float currentRotationX = 0;

    void LateUpdate()
    {
        if (target == null)
        {
            Debug.LogWarning("No target assigned to the camera!");
            return;
        }

        // Rotate the camera with the mouse input
        currentRotationX += Input.GetAxis("Mouse X") * rotationSpeed;

        // Calculate the rotation quaternion
        Quaternion rotation = Quaternion.Euler(0, currentRotationX, 0);

        // Calculate the desired camera position based on the offset and rotation
        Vector3 desiredPosition = target.position + rotation * offset;

        // Smoothly move the camera to the desired position
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 5);

        // Make the camera look at the target
        transform.LookAt(target.position);
    }
}

