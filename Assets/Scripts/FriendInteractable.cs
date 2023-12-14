using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class FriendInteractable : MonoBehaviour
{
    public Transform player;
   public void Interact()
    {
        Vector3 direction = player.position - transform.position;
        direction.y = 0f;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Euler(0f, rotation.eulerAngles.y, 0f);
    }
}
