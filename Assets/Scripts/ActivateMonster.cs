using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMonster : MonoBehaviour
{
    [SerializeField] GameObject monster;
    [SerializeField] GameObject backToCarUI;
    [SerializeField] GameObject investigateNoiseUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            monster.SetActive(true);
            backToCarUI.SetActive(true);
        }
    }

    private void Update()
    {
        if(backToCarUI.activeSelf)
        {
            investigateNoiseUI.SetActive(false);
        }
    }
}
