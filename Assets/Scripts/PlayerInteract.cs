using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] GameObject dialogueBox;
    private FirstPersonController FPSInput;

    private void Start()
    {
        dialogueBox.SetActive(false);
        FPSInput = GetComponent<FirstPersonController>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            dialogueBox.SetActive(true);
            FPSInput.MoveSpeed= 0;
            FPSInput.RotationSpeed= 0;
            FPSInput.SprintSpeed= 0;

            float interactRange = 2f;
            Collider [] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out FriendInteractable friendInteractable))
                {
                    friendInteractable.Interact();
                }
            }
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
