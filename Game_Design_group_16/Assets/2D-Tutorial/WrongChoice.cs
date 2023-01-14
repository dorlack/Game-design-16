using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WrongChoice : MonoBehaviour
{
    /// Add unpleasant audio
    /// 

    public void ButtonPressed()
    {
        /// Play unpleasant audio

        string pressedButton = EventSystem.current.currentSelectedGameObject.name;

        Debug.Log("Wrong button pressed");
        Debug.Log(pressedButton);
    }
}
