using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Control where the player Spawns, player should spawn on Secret Cell/room
    //create a function that checks for roomtype?

    public static PlayerManager instance;

    private Room secretRoom;

    public GameObject playerCharacter;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        //secretRoom = RoomManager.instance.SecretRoom;

        //Debug.Log(secretRoom.name);
        print("got reference to secret room");

        //I need to set player coords to the Secret Room coords
        //MoveToSecretRoom();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToSecretRoom()
    {
        Room secretRoom = RoomManager.instance.SecretRoom;
        UnityEngine.Debug.Log(RoomManager.instance.SecretRoom);
        
        if (secretRoom != null)
        {
            playerCharacter.transform.position = secretRoom.transform.position;
        }
    }
}
