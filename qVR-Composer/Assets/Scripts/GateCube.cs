using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GateCube : MonoBehaviour
{
    [SerializeField] private TextMeshPro frontLabel, backLabel, topLabel;
    [SerializeField] private OVRGrabbable gateGrabbable;

    public void SetLabel(string labelText)
    {
        frontLabel.text = labelText;
        backLabel.text = labelText;
        topLabel.text = labelText;
    }

    public bool IsGrabbed()
    {
        return gateGrabbable.isGrabbed;
    }
}
