using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsGrabbable : OVRGrabbable
{
    
    public FixedJoint joint = null;

    override public void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        m_grabbedBy = hand;
        m_grabbedCollider = grabPoint;
        
        joint = gameObject.AddComponent<FixedJoint>();
        joint.autoConfigureConnectedAnchor = true;
        joint.connectedBody = hand.GetComponent<Rigidbody>();
    }

    override public void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        Destroy(joint);

        rb.velocity = linearVelocity;
        rb.angularVelocity = angularVelocity;
        m_grabbedBy = null;
        m_grabbedCollider = null;
    }
}
