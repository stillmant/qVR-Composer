using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class BasisState : MonoBehaviour
{
    [SerializeField] Renderer stickRenderer, sphereRenderer;
    [SerializeField] GameObject probabilitySphere;
    [SerializeField] TextMeshPro basisLabel;

    private Vector3 zeroState = Vector3.zero;
    private Vector3 oneState = new Vector3(180, 0, 0);

    private Transform playerTransform;
    
    private void Awake()
    {
        playerTransform = Camera.main.transform;
    }

    private void Update()
    {
        var playerTransformRotationrotation = playerTransform.rotation;
        basisLabel.transform.LookAt(basisLabel.transform.position + playerTransformRotationrotation * Vector3.forward);
    }

    public void SetRotation(Vector3 newRotation)
    {
        gameObject.transform.Rotate(newRotation);
    }

    public void ChangeColor(Color newColor)
    {
        stickRenderer.material.color = newColor;
        sphereRenderer.material.color = newColor;
    }

    public void ScaleProbabilitySphere(Vector3 newScale)
    {
        probabilitySphere.transform.localScale = newScale;
    }

    public void SetToZeroState()
    {
        SetRotation(zeroState);
        basisLabel.text = "|0>";
    }

    public void SetToOneState()
    {
        SetRotation(oneState);
        basisLabel.text = "|1>";
    }
}
