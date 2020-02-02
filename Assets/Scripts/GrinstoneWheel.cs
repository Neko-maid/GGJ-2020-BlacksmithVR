using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrinstoneWheel : MonoBehaviour
{
    public bool IsOn = true;
    public float speed = 10f;
    public ParticleSystem Sparks;

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

    private void OnCollisionEnter(Collision collision)
    {
        Sparks.gameObject.SetActive(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        Sparks.gameObject.SetActive(false);
    }
}
