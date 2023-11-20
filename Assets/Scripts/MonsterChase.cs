using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AIController : MonoBehaviour
{

    public Transform Player;
    int MoveSpeed = 9;
    int MaxDist = 100;
    int MinDist = 0;




    void Start()
    {

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
}
