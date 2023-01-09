using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPressingTile : MonoBehaviour
{
    [SerializeField] public bool allowStateChange = true;
    [SerializeField] private bool revertsToNegative = false;
    [SerializeField] private bool initialStateTrue = false;
    private Material tileMaterial;
    private bool currentState;

    // Start is called before the first frame update
    void Start() {
        tileMaterial = this.GetComponent<Renderer>().material;
        changeState(initialStateTrue);
    }

    private void OnCollisionEnter(Collision collision) {

        if (allowStateChange) {
            changeState(true);
        }
    }

    private void OnCollisionExit(Collision collision) {
       
        if (allowStateChange && revertsToNegative) {
            changeState(false);
        }
    }

    public void changeState(bool newState) {

        currentState = newState;
        Color newColor = currentState? Color.green: Color.red;
        tileMaterial.color = newColor;
    }

    public bool getState() {
        return currentState;
    }
}
