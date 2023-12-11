using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        cam = Camera.main;
        eatFoodScript = GetComponent<EatFood>();

    }

    private void FixedUpdate()
    {
        eatFoodScript.InteractWithObjects(mousePos, mask, pressEText, car, cam);

        if(car.activeSelf == false)
        {
            SceneManager.LoadScene(2);
        }
    }
}
