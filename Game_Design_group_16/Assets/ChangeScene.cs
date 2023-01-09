using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject MainMenu;
    public GameObject Level1;
    public GameObject player;

    public void Start()
    {
        player.GetComponent<CameraSwitch>().enabled = false;
    }

    public void ChangeScenes()
    {
        if (Level1 != null) 
        {
            MainMenu.gameObject.SetActive(false);
            Level1.gameObject.SetActive(true);
        }
    }

    public void QuitApp()
    {
        Application.Quit();
        MainPanel.gameObject.SetActive(false);
        Cursor.visible = false; 
        player.GetComponent<CameraSwitch>().enabled = true;
    }
}
