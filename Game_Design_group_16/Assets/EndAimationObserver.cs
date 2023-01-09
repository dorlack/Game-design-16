using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAimationObserver : MonoBehaviour
{
    public GameObject player_cam;
    public GameObject zoom1;
    
    public void AlertObservers(string message)
    {
        if (message.Equals("Screen out animation ended"))
        {
            player_cam.SetActive(true);
            zoom1.SetActive(false);
        }
    }
}
