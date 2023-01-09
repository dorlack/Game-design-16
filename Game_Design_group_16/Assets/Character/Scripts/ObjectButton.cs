using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectButton : MonoBehaviour
{
    [SerializeField] private bool initialStateGreen = false;
    [SerializeField] private bool allowedToModify = true;

    private Material objectMaterial;
    private bool currentState;

    private void Start()
    {
        currentState = initialStateGreen;

        objectMaterial = GetComponent<Renderer>().material;
        objectMaterial.color = currentState ? Color.green : Color.red;
    }

    public void toggle()
    {
        if (allowedToModify)
        {
            currentState ^= true;
            objectMaterial.color = currentState ? Color.green : Color.red;
        }
    }

    public bool getState()
    {
        return currentState;
    }
}
