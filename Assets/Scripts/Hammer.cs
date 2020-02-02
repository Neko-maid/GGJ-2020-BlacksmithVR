using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public GameObject hammerhead;

    void OnCollisionEnter(Collision collision)
    {
        Collider col = collision.contacts[0].thisCollider;
        if (col.gameObject == hammerhead)
        {
            
        }
    }
}
