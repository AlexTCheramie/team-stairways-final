﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public static int maxHealth = 3;
    public static int playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        //Player spawn with full HP
        playerHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //Make sure the player's HP does not go higher than wanted
        if (playerHealth > maxHealth)
        {
            playerHealth = maxHealth;
        }

        //HP Stuff for Testing
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerHealth -= 1;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            playerHealth += 1;
        }
    }

    //Static function for adding health to the player (send it negative value to subtract health)
    public static void AddHealth(int amt)
    {
        playerHealth += amt;
    }

}