using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject player;
    public GameObject MainPanel;
    public GameObject MainMenu;
    public GameObject Help1;
    public GameObject Help2;
    public GameObject Help3;
    public GameObject Help4;
    public GameObject Help5;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Current;

    public void Start()
    {
        player.GetComponent<CameraSwitch>().enabled = false;
    }

    public void ChangeScenes()
    {
        if (Help1 != null) 
        {
            MainMenu.gameObject.SetActive(false);
            Help1.gameObject.SetActive(true);
        }
    }

    public void ChangeHelp1()
    {
        if (Help2 != null) 
        {
            Help1.gameObject.SetActive(false);
            Help2.gameObject.SetActive(true);
        }
    }

    public void ChangeHelp2()
    {
        if (Help3 != null) 
        {
            Help2.gameObject.SetActive(false);
            Help3.gameObject.SetActive(true);
        }
    }

    public void ChangeHelp3()
    {
        if (Help4 != null) 
        {
            Help3.gameObject.SetActive(false);
            Help4.gameObject.SetActive(true);
        }
    }

    public void ChangeHelp4()
    {
        if (Help5 != null) 
        {
            Help4.gameObject.SetActive(false);
            Help5.gameObject.SetActive(true);
        }
    }

    public void ChangeHelp5()
    {
        if (Current != null) 
        {
            Help5.gameObject.SetActive(false);
            Current.gameObject.SetActive(true);
        }
    }

    public void ChangeHelpCurrent1()
    {
        if (Level1 != null) 
        {
            Current.gameObject.SetActive(false);
            Help1.gameObject.SetActive(true);
        }
    }

    public void ChangeHelpCurrent2()
    {
        if (Level2 != null) 
        {
            Current = Level2;
            Current.gameObject.SetActive(false);
            Help1.gameObject.SetActive(true);
        }
    }

    public void ChangeHelpCurrent3()
    {
        if (Level3 != null) 
        {
            Current = Level3;
            Current.gameObject.SetActive(false);
            Help1.gameObject.SetActive(true);
        }
    }
    
    public void ChangeLevel1()
    {
        if (Level2 != null) 
        {
            Level1.gameObject.SetActive(false);
            Level2.gameObject.SetActive(true);
        }
    }

    public void ChangeLevel2()
    {
        if (Level3 != null) 
        {
            Level2.gameObject.SetActive(false);
            Level3.gameObject.SetActive(true);
        }
    }

    public void ChangeLevel3()
    {
        if (Level3 != null) 
        {
            Level3.gameObject.SetActive(false);
            Level3.gameObject.SetActive(true);
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
