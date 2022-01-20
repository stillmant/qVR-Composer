using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QSphereController : MonoBehaviour
{
    [SerializeField] private BasisState basisStatePrefab;
    private List<BasisState> basisStates = new List<BasisState>();

    private void Start()
    {
        AddBasisState();
        AddBasisState();
        basisStates[0].SetToOneState();
        basisStates[1].SetToZeroState();
    }

    public void AddBasisState()
    {
        var newBasisState = Instantiate(basisStatePrefab, gameObject.transform);
        basisStates.Add(newBasisState);
    }
}
