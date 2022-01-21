using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapZone : MonoBehaviour
{
    private GameObject thisSnapZoneObj;
    private GateCube gateRef;
    private Rigidbody gateRigidbody;
    
    private void OnTriggerEnter(Collider other)
    {
        gateRef = other.GetComponent<GateCube>();
        gateRigidbody = other.GetComponent<Rigidbody>();
        thisSnapZoneObj = gameObject;
    }

    private void Update()
    {
        if (!gateRef.IsGrabbed())
        {
            var otherTransform = gateRef.transform;
            gateRigidbody.isKinematic = true;
            otherTransform.position = thisSnapZoneObj.transform.position;
            otherTransform.rotation = thisSnapZoneObj.transform.rotation;
        }
    }

    /*private void OnTriggerStay(Collider other)
    {
        if (!gateRef.IsGrabbed())
        {
            var otherTransform = other.transform;
            gateRigidbody.isKinematic = true;
            otherTransform.position = thisSnapZoneObj.transform.position;
            otherTransform.rotation = thisSnapZoneObj.transform.rotation;
        }
    }*/
    
}
