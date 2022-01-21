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
        basisStates[0].SetToZeroState();
    }

    public void AddBasisState()
    {
        var newBasisState = Instantiate(basisStatePrefab, gameObject.transform);
        basisStates.Add(newBasisState);
    }

    public List<BasisState> GetBasisStates()
    {
        return basisStates;
    }
}
