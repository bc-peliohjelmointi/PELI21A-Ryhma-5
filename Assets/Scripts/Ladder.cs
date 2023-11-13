using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class Ladder : MonoBehaviour
{
   [SerializeField] Transform playerController;
   bool canClimb = false;
   [SerializeField] float speedUpDown = 3.2f;
   [SerializeField] FirstPersonController FPSInput;
   

   private void Start() {
    FPSInput = GetComponent<FirstPersonController>();
    canClimb = false;
   }

   private void OnTriggerEnter(Collider other) {
    if(other.tag == "Ladder"){
        Debug.Log("testi");
        FPSInput.enabled = false;
        canClimb = !canClimb;
    }
   }

   void OnTriggerExit(Collider other){
    if(other.tag == "Ladder"){
        FPSInput.enabled = true;
        canClimb = !canClimb;
    }
   }
   

   private void Update() {
    if(canClimb == true && Input.GetKey("W")){
        playerController.transform.position += Vector3.up / speedUpDown * Time.deltaTime;
    }

    if (canClimb == true && Input.GetKey("S")){
        playerController.transform.position += Vector3.down / speedUpDown * Time.deltaTime;
    }
   }
}
