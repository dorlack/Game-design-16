using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WrongChoice : MonoBehaviour
{
    public AudioSource screenSource;
    public AudioClip unpleasantSound;

    public void ButtonPressed()
    {
        screenSource.PlayOneShot(unpleasantSound);

        string pressedButton = EventSystem.current.currentSelectedGameObject.name;

        Debug.Log("Wrong button pressed");
        Debug.Log(pressedButton);
    }
}
