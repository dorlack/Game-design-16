using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CorrectChoice : MonoBehaviour
{
    // Add pleasant sound

    public void ButtonPressed()
    {
        // Play pleasant sound

        GameObject pressedButton = EventSystem.current.currentSelectedGameObject;

        GameObject parent = pressedButton.transform.parent.gameObject;

        Transform[] allChildren = parent.GetComponentsInChildren<Transform>();
        foreach(Transform child in allChildren)
        {
            if (child.gameObject.name.Equals("ProceedButton"))
            {
                child.gameObject.GetComponent<Button>().interactable = true;
            }
        }

        Debug.Log("Correct button pressed");
        Debug.Log(pressedButton);
    }
}
