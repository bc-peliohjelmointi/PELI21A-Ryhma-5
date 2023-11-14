using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldBarrierMessage : MonoBehaviour
{
    [SerializeField]
    private Text yourText;

    void Start()
    {
        yourText.enabled = false;
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            yourText.enabled = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            yourText.enabled = false; 
        }
    }
}
