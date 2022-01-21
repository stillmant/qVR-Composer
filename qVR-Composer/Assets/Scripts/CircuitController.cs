using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitController : MonoBehaviour
{
    [SerializeField] private QSphereController qSphereController;
    [SerializeField] private SnapZone snapZone;

    private bool stateChanged;

    private void Update()
    {
        if (!snapZone.hasGate) return;
        ChangeState();
    }

    private void ChangeState()
    {
        if (stateChanged) return;
        qSphereController.GetBasisStates()[0].SetToOneState();
        stateChanged = true;
    }
}
