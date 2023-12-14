using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectTaskNote : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] GameObject taskList;
    [SerializeField] GameObject note;
    [SerializeField] GameObject pickUpNote;
    Camera cam;
    Vector3 mousePos;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {
        mousePos = Input.mousePosition;
        mousePos.z = 100f;
        mousePos = cam.ScreenToWorldPoint(mousePos);
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 2, mask))
        {
            pickUpNote.SetActive(true);
        }

        else
        {
            pickUpNote.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(ray, out hit, 2, mask))
            {
                note.SetActive(false);
                taskList.SetActive(true);
            }
        }
    }
}
