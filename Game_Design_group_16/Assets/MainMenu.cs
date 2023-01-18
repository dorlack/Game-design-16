using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject player;
    public GameObject MainPanel;
    public GameObject Menu;
    public GameObject ContinueButton;

    private ChangeScene cs;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<CameraSwitch>().enabled = false;
        cs = MainPanel.GetComponent<ChangeScene>();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!cs.LastActiveIsNull())
        {
            ContinueButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            ContinueButton.GetComponent<Button>().interactable = false;
        }
    }

    public void QuitApp()
    {
        Application.Quit();
        MainPanel.gameObject.SetActive(false);
        Cursor.visible = false;

        CameraSwitch sw = player.GetComponent<CameraSwitch>();
        sw.enabled = true;
        sw.Invoke("Escape", 0);
    }

    public void ContinueButtonPressed()
    {
        cs.Invoke("ChangeToLastActive", 0);
    }

    public void StartButtonPressed()
    {
        cs.Invoke("ChangeScenes", 0);
    }
}
