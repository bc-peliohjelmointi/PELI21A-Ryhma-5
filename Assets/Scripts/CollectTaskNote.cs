using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTaskNote : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] GameObject taskList;
    [SerializeField] GameObject note;
    [SerializeField] GameObject pickUpNote;
    EatFood eatFoodScript;
    Camera cam;
    Vector3 mousePos;

    private void Start()
    {
        cam = Camera.main;
        eatFoodScript = GetComponent<EatFood>();
    }

    private void FixedUpdate()
    {
        eatFoodScript.InteractWithObjects(mousePos, mask, pickUpNote, note, cam);

        if (eatFoodScript.hasPressedE)
        {
            taskList.SetActive(true); ;
        }
        
    }
}
