using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] public string doorOpen = "DoorOpen";
    [SerializeField] public string doorClose = "DoorClose";

    [SerializeField] public bool openTrigger = false;
    [SerializeField] public bool closeTrigger = false;

    [SerializeField] public GameObject closeDoorTrigger;
    [SerializeField] public GameObject openDoorTrigger;

    public void OnTriggerEnter(Collider other) {

        if (other.CompareTag("Player")) {

            if (openTrigger) {

                myDoor.Play(doorOpen, 0, 0.0f);
                gameObject.SetActive(false);
                closeDoorTrigger.SetActive(true);
            } else if (closeTrigger) {
                
                myDoor.Play(doorClose, 0, 0.0f);
                gameObject.SetActive(false);
                openDoorTrigger.SetActive(true);

            }
        }

    }
}
