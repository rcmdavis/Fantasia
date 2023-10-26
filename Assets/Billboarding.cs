using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboarding : MonoBehaviour
{
    public Transform billboard;
    public Transform cam;

    void Update()
    {

        billboard.LookAt(cam.position);
    }
}
