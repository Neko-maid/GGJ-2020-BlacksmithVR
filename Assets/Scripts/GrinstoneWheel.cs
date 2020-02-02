using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrinstoneWheel : MonoBehaviour
{
    public bool IsOn = true;
    public float speed = 10f;


    void Update()
    {
        if (IsOn)
        {
            RotateWheel();
        }
    }

    void RotateWheel()
    {
        Vector3 axis = new Vector3(0, -1, 0);
        transform.Rotate(axis, speed);
    }
}
