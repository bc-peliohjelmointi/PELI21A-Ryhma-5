using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using StarterAssets;

public class Dialogue : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent; 
    [SerializeField] float textSpeed; 
    [SerializeField] string[] lines;

    public bool dialogueActive = false;

    private int index;
   // private FirstPersonController FPSInput;

    void StartDialogue(){
        dialogueActive= true;
        index = 0;
        StartCoroutine(TypeLine());
    } 

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
        //FPSInput = GetComponent<FirstPersonController>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }

            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }
    IEnumerator TypeLine(){
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
   }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine (TypeLine());
        }

        else
        {
            gameObject.SetActive(false);
            dialogueActive= false;
        }
    }
}
