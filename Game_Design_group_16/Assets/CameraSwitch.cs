using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Transform PlayerCamera;
    public GameObject player_cam;
    public GameObject zoom1;
    public GameObject player;
    public float MaxDistance = 10;
    private Animator anim;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (player_cam.activeSelf) 
            {
                Pressed();
            } else {
                //Escape();
            }
        }
    }

    void Pressed()
    {
        //This will name the Raycasthit and came information of which object the raycast hit.
        RaycastHit screenhit;
 
        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out screenhit, MaxDistance))
        {
            // if raycast hits, then it checks if it hit an object with the tag Door.
            if (screenhit.transform.tag == "Screen")
            {
                player.GetComponent<PlayerMovement>().enabled = false;
                zoom1.SetActive(true);
                player_cam.SetActive(false);
                //This line will get the Animator from  Parent of the door that was hit by the raycast.
                zoom1.GetComponent<Animator>().Play("Programming zoom");
                Debug.Log("CameraSwitch Played");
                //This will set the bool the opposite of what it is.
            }
        }
    }

    void Escape()
    {
        RaycastHit screenhit;

        if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out screenhit, MaxDistance)) 
        {
            if (screenhit.transform.tag == "Screen")
            {
                zoom1.GetComponent<Animator>().Play("Programming out");
                player.GetComponent<PlayerMovement>().enabled = true;
            }
        }
    }
}
