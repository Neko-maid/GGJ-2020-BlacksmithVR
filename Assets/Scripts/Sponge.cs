using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sponge : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rigidbody;
    BaseWeapon lastPolished;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Blade" && collision.gameObject.GetComponentInParent<BaseWeapon>()) {
            Debug.Log("I am touch " + collision.gameObject);
            lastPolished = collision.gameObject.GetComponentInParent<BaseWeapon>();
        }
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("we stay");
        if(collision.gameObject.tag == "Blade") {
            Debug.Log(rigidbody.velocity.magnitude);
            lastPolished.polishAmount -= rigidbody.velocity.magnitude;

        }
    }
}
