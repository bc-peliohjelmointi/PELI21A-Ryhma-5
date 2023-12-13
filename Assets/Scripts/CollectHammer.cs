using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectHammer : MonoBehaviour
{
    [SerializeField] LayerMask mask;
    [SerializeField] GameObject taskList;
    public GameObject hammer;
    [SerializeField] GameObject pickUpHammer;
    [SerializeField] GameObject investigateNoiseUI;
    [SerializeField] TMP_Text taskText;
    [SerializeField] GameObject pickUpFireWood;
    [SerializeField] GameObject monsterActivation;
    [SerializeField] GameObject friend;
    EatFood eatFoodScript;
    CollectFirewood fireWoodScript;
    Camera cam;
    public GameObject monnsterScream;
    Vector3 mousePos;
    private bool tasksDone = false;

    private void Start()
    {
        cam = Camera.main;
        eatFoodScript = GetComponent<EatFood>();
        fireWoodScript= GetComponent<CollectFirewood>();
    }

    private void Update()
    {
        if (taskList.activeSelf == true)
        {
            eatFoodScript.InteractWithObjects(mousePos, mask, pickUpHammer, hammer, cam);
        }

        if (hammer.activeSelf == false && fireWoodScript.fireWood1.activeSelf == true && fireWoodScript.fireWood2.activeSelf == true
            && fireWoodScript.fireWood3.activeSelf == true && fireWoodScript.fireWood4.activeSelf == true && fireWoodScript.fireWood5.activeSelf == true ){
            taskText.text = "- Find and collect 5 piles of Firewood near the shed";
        }

        else if (hammer.activeSelf == false && fireWoodScript.fireWood1.activeSelf == false && fireWoodScript.fireWood2.activeSelf == false
            && fireWoodScript.fireWood3.activeSelf == false && fireWoodScript.fireWood4.activeSelf == false && fireWoodScript.fireWood5.activeSelf == false )
        {
            taskList.SetActive(false);
            pickUpHammer.SetActive(false);
            pickUpFireWood.SetActive(false);
            monnsterScream.SetActive(true);
            monsterActivation.SetActive(true);
            friend.SetActive(false);
            tasksDone = true;
        }
    }

    private void FixedUpdate()
    {
        if (tasksDone)
        {
            investigateNoiseUI.SetActive(true);
        }
    }
}
