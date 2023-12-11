using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFirewood : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] GameObject taskList;
    [SerializeField] GameObject fireWood1;
    [SerializeField] GameObject fireWood2;
    [SerializeField] GameObject fireWood3;
    [SerializeField] GameObject fireWood4;
    [SerializeField] GameObject fireWood5;
    [SerializeField] GameObject pickUpFireWood;
    EatFood eatFoodScript;
    Camera cam;
    Vector3 mousePos;

    private void Start()
    {
        cam = GetComponent<Camera>();
        eatFoodScript = GetComponent<EatFood>();
    }

    private void FixedUpdate()
    {
        if(taskList.activeSelf == true)
        {
            eatFoodScript.InteractWithObjects(mousePos, mask, pickUpFireWood, fireWood1, cam);
            eatFoodScript.InteractWithObjects(mousePos, mask, pickUpFireWood, fireWood2, cam);
            eatFoodScript.InteractWithObjects(mousePos, mask, pickUpFireWood, fireWood3, cam);
            eatFoodScript.InteractWithObjects(mousePos, mask, pickUpFireWood, fireWood4, cam);
            eatFoodScript.InteractWithObjects(mousePos, mask, pickUpFireWood, fireWood5, cam);
        }
    }
}
