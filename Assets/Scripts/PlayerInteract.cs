using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] GameObject dialogueBox;

    private void Start()
    {
        dialogueBox.SetActive(false);
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
