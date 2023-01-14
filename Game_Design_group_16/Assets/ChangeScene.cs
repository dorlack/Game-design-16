using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject player;
    public GameObject MainPanel;
    public GameObject MainMenu;
    public GameObject Tutorial1;
    public GameObject Tutorial2;
    public GameObject Tutorial3;
    public GameObject Tutorial4;
    public GameObject Tutorial5;
    public GameObject VariablesHint;
    public GameObject Help1;
    public GameObject Help2;
    public GameObject Help3;
    public GameObject Help4;
    public GameObject Help5;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Current;

    // add unexpected sound
    // add short animation.

    public void Start()
    {
        player.GetComponent<CameraSwitch>().enabled = false;
    }

    public void ChangeScenes()
    {
        if (Tutorial1 != null) 
        {
            MainMenu.gameObject.SetActive(false);
            Tutorial1.gameObject.SetActive(true);
        }
    }

    public void ChangeTutorial1()
    {
        if (Tutorial2 != null)
        {
            Tutorial1.gameObject.SetActive(false);
            Tutorial2.gameObject.SetActive(true);
        }
    }

    public void ChangeTutorial2()
    {
        if (Tutorial3 != null)
        {
            Tutorial2.gameObject.SetActive(false);
            Tutorial3.gameObject.SetActive(true);
        }
    }
    public void ChangeTutorial3()
    {
        if (Tutorial4 != null)
        {
            Tutorial3.gameObject.SetActive(false);
            Tutorial4.gameObject.SetActive(true);
        }
    }
    public void ChangeTutorial4()
    {
        if (Tutorial5 != null)
        {
            Tutorial4.gameObject.SetActive(false);
            Tutorial5.gameObject.SetActive(true);
        }
    }
    public void ChangeTutorial5()
    {
        if (VariablesHint != null)
        {
            Tutorial5.gameObject.SetActive(false);
            VariablesHint.gameObject.SetActive(true);
            // play unexpected sound
            // play short animation of waring
        }
    }

    public void ChangeVariablesHint()
    {
        if (Level1 != null)
        {
            VariablesHint.gameObject.SetActive(false);
            Level1.gameObject.SetActive(true);
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
