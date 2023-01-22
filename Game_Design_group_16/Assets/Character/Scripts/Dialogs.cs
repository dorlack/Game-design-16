using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogs : MonoBehaviour
{


    public GameObject dialogBox;    // dialog box
    PlayerMovement character;  // the main character control script
    TextMeshProUGUI dialogText;     // dialog text in  the box
    TextMeshProUGUI dialogActor;    // dialog cator in the box

    public Transform PlayerCamera;
    [Header("MaxDistance you can open or close the door.")]
    public float MaxDistance = 15;

    private bool inDialigue = false;

    int size, index;
    Message[] messages;
    Actor[] actors;

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
        character = GetComponent<PlayerMovement>();

        /*
        Get all children components of DialogBox    */
        int i = 0;
        GameObject[] allChildren = new GameObject[dialogBox.transform.childCount];
        foreach (Transform child in dialogBox.transform)
        {
            allChildren[i] = child.gameObject;
            i++;
        }
        dialogText = allChildren[0].GetComponent<TextMeshProUGUI>();
        dialogActor = allChildren[1].GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!inDialigue)
            {
                Pressed();
            }
            else
            {
                index++;
                if (index >= size)
                {
                    character.enabled = true;
                    Time.timeScale = 1.0f;
                    dialogBox.SetActive(false);
                    manager.enabled = false;
                    inDialigue = false;
                }
                else
                {
                    dialogText.text = messages[index].message;
                    dialogActor.text = actors[messages[index].actorId].name;
                }
            }
        }
    }

    DialogManager manager;  // the dialog we want to display

    void Pressed()
    {
        //This will name the Raycasthit and came information of which object the raycast hit.
        RaycastHit NPC;

        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out NPC, MaxDistance))
        {
            // if raycast hits, then it checks if it hit an object with the tag Door.
            if (NPC.transform.tag == "NPC")
            {
                Debug.Log(NPC.transform.gameObject);

                manager = NPC.transform.gameObject.GetComponent<DialogManager>();

                if (manager.isFinished)
                {
                    return;
                }
                    
                Time.timeScale = 0.0f;  // freeze the game

                character.enabled = false;
                messages = manager.messages;
                actors = manager.actors;

                size = messages.Length;
                index = 0;

                dialogText.text = messages[index].message;

                dialogActor.text = actors[messages[index].actorId].name;
                dialogBox.SetActive(true);
                inDialigue = true;
                manager.isFinished = true;

            }
        }
    }
}
