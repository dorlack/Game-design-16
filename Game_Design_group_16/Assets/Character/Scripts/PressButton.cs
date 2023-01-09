using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private float pressDistance = 2f;
    [SerializeField] private LayerMask pickUpLayerMask;

    private ObjectButton objectButton;

    private void Update()
    {
        if (Input.GetButtonDown("Interract"))
        {
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pressDistance, pickUpLayerMask))
            {
                if (raycastHit.transform.TryGetComponent(out objectButton))
                {
                    objectButton.toggle();
                }
            }
        }
    }
}
