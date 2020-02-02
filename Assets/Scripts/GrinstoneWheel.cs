using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrinstoneWheel : MonoBehaviour
{
    public bool IsOn = true;
    public float speed = 10f;
    public ParticleSystem Sparks;
    private Transform anim_object;

    void Start()
    {
        anim_object = gameObject.transform.GetChild(0);
    }

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
        anim_object.Rotate(axis, speed);
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
