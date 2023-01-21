using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CorrectChoice : MonoBehaviour
{
    public AudioSource screenSource;
    public AudioClip pleasantSound;

    public void ButtonPressed()
    {
        screenSource.PlayOneShot(pleasantSound);

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
