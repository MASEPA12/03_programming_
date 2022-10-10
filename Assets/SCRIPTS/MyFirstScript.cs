using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
     This is a multiline comment;
     4 variables with the player information
    */
//This variable says the PLAYER'S AGE
    public int playerAge = 23; 

//This variable says the PLAYER'S SPEED
    public float playerSpeed = 3.125f;

//This variable says the PLAYER NICKNAME
    public string playerName = "masepa"; 

//This variable says if the player has lost
    [SerializeField]private bool gameOver = false; 
}


