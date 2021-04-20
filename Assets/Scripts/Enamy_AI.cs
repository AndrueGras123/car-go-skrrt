using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_AI : MonoBehaviour
{

    float moveSpeed = 3.0f;
    private GameObject character;
    public GameObject player;
    void Start()
    {
        character = GetComponent<GameObject>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        //code for looking to player
        character.transform.rotation = Quaternion.Slerp(character.transform.rotation,
        Quaternion.LookRotation(player.transform.position - character.transform.position), 3 * Time.deltaTime);

        //code for following the player
        character.transform.position += character.transform.forward * moveSpeed * Time.deltaTime;
    }




}