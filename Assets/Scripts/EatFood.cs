using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatFood : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    Camera cam;
    [SerializeField] GameObject eatFoodUI;
    [SerializeField] GameObject food;
    Vector3 mousePos;

    private void Start()
    {
        cam = Camera.main;
    }
    private void Update()
    {
        InteractWithObjects(mousePos, mask, eatFoodUI, food, cam);
    }

    public void InteractWithObjects(Vector3 pos, LayerMask mask, GameObject UI, GameObject item, Camera cam)
    {
        pos = Input.mousePosition;
        pos.z = 100f;
        pos = cam.ScreenToWorldPoint(pos);
        //Debug.DrawRay(transform.position, mousePos - transform.position, Color.blue);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 2, mask))
        {
            if(hit.collider.gameObject == item)
            {
                UI.SetActive(true);
            }
        }

        else
        {
            UI.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out hit, 2, mask))
            {
                if(hit.collider.gameObject == item)
                {
                    item.SetActive(false);
                }
            }
        }
    }
}
