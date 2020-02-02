using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsGrabbable : OVRGrabbable
{
    public SpringJoint joint;

    override protected void Start()
    {
        joint = gameObject.AddComponent<SpringJoint>();
        joint.autoConfigureConnectedAnchor = true;
    }

    override public void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        m_grabbedBy = hand;
        m_grabbedCollider = grabPoint;
        joint.connectedBody = hand.gameObject.GetComponent<Rigidbody>();
    }

    override public void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        joint.connectedBody = null;
        rb.velocity = linearVelocity;
        rb.angularVelocity = angularVelocity;
        m_grabbedBy = null;
        m_grabbedCollider = null;
    }
}
