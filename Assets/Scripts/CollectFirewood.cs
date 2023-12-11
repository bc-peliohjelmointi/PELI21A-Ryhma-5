using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFirewood : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] GameObject taskList;
    [SerializeField] GameObject fireWood;
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
            eatFoodScript.InteractWithObjects(mousePos, mask, pickUpFireWood, fireWood, cam);
        }
    }
}
