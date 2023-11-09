using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Ladder : MonoBehaviour
{
   [SerializeField] Transform playerController;
   bool inside = false;
   [SerializeField] float speedUpDown = 3.2f;
   [SerializeField] FirstPersonController FPSInput;

   private void Start() {
    FPSInput = GetComponent<FirstPersonController>();
    inside = false;
   }

   private void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag == "Ladder"){
        FPSInput.enabled = false;
        inside = !inside;
    }
   }

   void OnTriggerExit(Collider other){
    if(other.gameObject.tag == "Ladder"){
        FPSInput.enabled = true;
        inside = !inside;
    }
   }

   private void Update() {
    if(inside == true && Input.GetKey("w")){
        playerController.transform.position += Vector3.up * speedUpDown * Time.deltaTime;
    }

    if (inside == true && Input.GetKey("s")){
        playerController.transform.position += Vector3.down * speedUpDown * Time.deltaTime;
    }
   }
}
