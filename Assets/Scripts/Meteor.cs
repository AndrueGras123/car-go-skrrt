using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public Transform coins;
    public Transform magnet;
    public float speed = 9f;
    float distanceToGround;
    Vector3 Groundnormal;
    bool OnGround = false;

    void FixedUpdate()
    {
        coins.position = Vector3.MoveTowards(coins.position, magnet.position, speed * Time.deltaTime);
    }


    void Update()
    {
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, -transform.up, out hit, 10))
        {

            distanceToGround = hit.distance;
            Groundnormal = hit.normal;

            if (distanceToGround <= 2)
            {
                OnGround = true;
            }
            else
            {
                OnGround = false;
            }


        }
    }
}