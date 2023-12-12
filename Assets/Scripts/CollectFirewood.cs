using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CollectFirewood : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] GameObject taskList;
    [SerializeField] TMP_Text taskText;
    public GameObject fireWood1;
    public GameObject fireWood2;
    public GameObject fireWood3;
    public GameObject fireWood4;
    public GameObject fireWood5;
    [SerializeField] GameObject pickUpFireWood;
    EatFood eatFoodScript;
    Camera cam;
    Vector3 mousePos;
    CollectHammer hammerScript;

    private void Start()
    {
        cam = Camera.main;
        eatFoodScript = GetComponent<EatFood>();
        hammerScript = GetComponent<CollectHammer>();
    }

    private void Update()
    {
        
          if (taskList.activeSelf == true)
        {
            CheckFirewoodCollection(fireWood1);
            CheckFirewoodCollection(fireWood2);
            CheckFirewoodCollection(fireWood3);
            CheckFirewoodCollection(fireWood4);
            CheckFirewoodCollection(fireWood5);
        }
        
        
        if (fireWood1.activeSelf == false && fireWood2.activeSelf == false && fireWood3.activeSelf == false && fireWood4.activeSelf == false && fireWood5.activeSelf == false && hammerScript.hammer.activeSelf == true)
        {
            taskText.text = "- Retrieve hammer from the shed";    
            pickUpFireWood.SetActive(false);
        }
    }

    private void CheckFirewoodCollection(GameObject fireWood)
    {
        if (fireWood.activeSelf)
        {
            eatFoodScript.InteractWithObjects(mousePos, mask, pickUpFireWood, fireWood, cam);
        }
    }
}
