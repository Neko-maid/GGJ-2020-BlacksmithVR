using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject cube;
    void Start()
    {
        cube = transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();

        if(OVRInput.Get(OVRInput.Button.One)) {
            cube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        } else {
            cube.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }

        if(OVRInput.Get(OVRInput.RawButton.A)) {
            cube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        } else {
            cube.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        }

    }
}
