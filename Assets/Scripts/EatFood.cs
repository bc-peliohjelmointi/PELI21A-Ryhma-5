using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFood : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    Camera cam;
    [SerializeField] GameObject eatFoodUI;
    [SerializeField] GameObject food;

    private void Start()
    {
        cam = Camera.main;
    }
    private void FixedUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = cam.ScreenToWorldPoint(mousePos);
        //Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100, mask))
        {
            eatFoodUI.SetActive(true);
        }

        else
        {
            eatFoodUI.SetActive(false);
        }
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(Physics.Raycast(ray, out hit, 100, mask)) 
            {
                food.SetActive(false);
            }
        }
    }
}
