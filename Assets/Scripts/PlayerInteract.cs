using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject dialogueBox;

    private FirstPersonController FPSInput;
    private Dialogue dialogue;

    private void Start()
    {
        dialogueBox.SetActive(false);
        FPSInput = GetComponent<FirstPersonController>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider [] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out FriendInteractable friendInteractable))
                {
                    dialogueBox.SetActive(true);
                    FPSInput.MoveSpeed = 0;
                    FPSInput.SprintSpeed= 0;
                    friendInteractable.Interact();
                }
            }
        }

        if(dialogueBox.activeSelf == false)
        {
            FPSInput.MoveSpeed = 4;
            FPSInput.SprintSpeed = 6;
        }
    }

    public FriendInteractable GetInteractableObject()
    {
        float interactRange = 2f;
        Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
        foreach (Collider collider in colliderArray)
        {
            if (collider.TryGetComponent(out FriendInteractable friendInteractable))
            {
                return friendInteractable;

            }
        }
        return null;
    }
}
