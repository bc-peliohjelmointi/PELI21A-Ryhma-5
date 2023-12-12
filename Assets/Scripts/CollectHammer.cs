using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHammer : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] GameObject taskList;
    [SerializeField] GameObject hammer;
    [SerializeField] GameObject pickUpHammer;
    EatFood eatFoodScript;
    CollectFirewood fireWoodScript;
    Camera cam;
    Vector3 mousePos;

    private void Start()
    {
        cam = Camera.main;
        eatFoodScript = GetComponent<EatFood>();
        fireWoodScript= GetComponent<CollectFirewood>();
    }

    private void FixedUpdate()
    {
        if (taskList.activeSelf == true)
        {
            eatFoodScript.InteractWithObjects(mousePos, mask, pickUpHammer, hammer, cam);
        }
    }

    private void Update()
    {
        if (hammer.activeSelf == false && fireWoodScript.fireWood1.activeSelf == false && fireWoodScript.fireWood2.activeSelf == false
            && fireWoodScript.fireWood3.activeSelf == false && fireWoodScript.fireWood4.activeSelf == false && fireWoodScript.fireWood5.activeSelf == false )
        {
            taskList.SetActive(false);
        }
    }
}
