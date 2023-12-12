using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarInteract : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] GameObject car;
    [SerializeField] GameObject pressEText;
    [SerializeField] GameObject monster;
    EatFood eatFoodScript;
    Camera cam;
    Vector3 mousePos;

    private void Start()
    {
        cam = Camera.main;
        eatFoodScript = GetComponent<EatFood>();

    }

    private void Update()
    {
        if(monster.activeSelf == true)
        {
            eatFoodScript.InteractWithObjects(mousePos, mask, pressEText, car, cam);

            if (car.activeSelf == false)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}
