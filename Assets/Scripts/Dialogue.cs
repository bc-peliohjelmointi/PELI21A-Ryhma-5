using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Dialogue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent; 
    [SerializeField] float textSpeed; 
    [SerializeField] string[] lines;

    private int index;

    void StartDialogue(){
        index = 0;
    } 

    //IENumerator TypeLine(){

   // }
}
