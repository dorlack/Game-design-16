using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAimationObserver : MonoBehaviour
{
    public GameObject player_cam;
    public GameObject zoom1;
    public GameObject Panel;
    public GameObject MainMenu;
    
    public void AlertObservers(string message)
    {
        if (message.Equals("Programming Screen out animation ended"))
        {
            player_cam.SetActive(true);
            zoom1.SetActive(false);
        }
        if (message.Equals("Programming Screen zoom animation ended"))
        {
                Panel.gameObject.SetActive(true);
                MainMenu.gameObject.SetActive(true);
        }
    }
}
