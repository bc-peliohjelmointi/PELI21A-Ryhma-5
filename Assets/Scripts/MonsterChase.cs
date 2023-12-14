using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AIController : MonoBehaviour
{

    public Transform Player;
    public GameObject ThePlayer;
    public AudioSource Scream;
    public GameObject JumpZombie;
    public GameObject flashImg;
    public float MoveSpeed = 7.5f;
    int MaxDist = 100;
    int MinDist = 0;




    void Start()
    {
        JumpZombie.SetActive(false);
        flashImg.SetActive(false);
    }

    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;



            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                
            }

        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Scream.Play();
            JumpZombie.SetActive(true);
            flashImg.SetActive(true);
            ThePlayer.SetActive(false);
            Destroy(gameObject);
        }
    }
}
