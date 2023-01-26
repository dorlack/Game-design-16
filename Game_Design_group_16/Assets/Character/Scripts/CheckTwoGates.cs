using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTwoGates : MonoBehaviour
{
    public GameObject tile1;
    public GameObject tile2;
    public GameObject character;

    private ObjectPressingTile tileScript1;
    private ObjectPressingTile tileScript2;

    void Start()
    {
        character.SetActive(false);
        tileScript1 = tile1.GetComponent<ObjectPressingTile>();
        tileScript2 = tile2.GetComponent<ObjectPressingTile>();

    }

    // Update is called once per frame
    void Update()
    {
        if (tileScript1.getState() == tileScript2.getState() && tileScript1.getState() == true)
        {
            character.SetActive(true);
            Destroy(this);
        }
    }
}
