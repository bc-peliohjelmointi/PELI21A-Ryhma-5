using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FriendInteractable : MonoBehaviour
{
    public Transform player;
   public void Interact()
    {
        transform.LookAt(player);
        Debug.Log("Interact!");
    }
}
