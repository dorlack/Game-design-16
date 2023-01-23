using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPressingTile : MonoBehaviour
{
    [SerializeField] private bool isGatePlaceholder = false;
    [SerializeField] private List<string> gateType;

    [SerializeField] public bool allowStateChange = true;

    [SerializeField] private bool doorTile = false;
    [SerializeField] public Animator myDoor = null;
    [SerializeField] public string doorOpen = "DoorOpen";
    [SerializeField] public string doorClose = "DoorClose";

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

        if (allowStateChange && isGatePlaceholder) {
            if (gateType.Contains(collision.gameObject.tag )) {
                changeState(true);
                //play good sound
            }
            else {
                //play bad sound
            }
        }

        if (allowStateChange && !isGatePlaceholder) {
            changeState(true);
        }
    }

    private void OnCollisionExit(Collision collision) {
       
        if (allowStateChange && revertsToNegative) {
            changeState(false);
        }

        if (doorTile) {
            myDoor.Play(doorClose, 0, 0.0f);
        }
    }

    private void OnTriggerEnter(Collider collision){
        if (doorTile) {
            myDoor.Play(doorOpen, 0, 0.0f);
        }
    }

    private void OnTriggerExit(Collider collision){
        if (doorTile) {
            myDoor.Play(doorClose, 0, 0.0f);
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
