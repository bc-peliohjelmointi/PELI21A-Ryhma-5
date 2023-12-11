using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInteract : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] GameObject car;
    [SerializeField] GameObject pressEText;
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
        eatFoodScript.InteractWithObjects(mousePos, mask, pressEText, car, cam);
    }
}
