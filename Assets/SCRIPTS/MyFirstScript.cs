using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    //variables
    public int playerAge = 23;
    public float playerSpeed = 3.125f;
    public string playerName = "Masepa";
    public int playerLives = 3;
    private string welcome = "Welcome to the race";
    public string message = "This is your puntiation";
    public int inicialPoints;
    public int finalPoints = 1000;
    [SerializeField] private bool gameOver = false;


    public float x = 2;
    public float y = 3;
    private float result;

    private void Start()
    {
       // result = x + y;
        x += y;
        Debug.Log(string.Format(
            "You have killed a mushroom and a butterfly, so you have now {0} points.", x));

       Debug.Log(welcome);
       Debug.Log(string.Format(
            "{0}, you have {1} lives and your inicial punctuation is {2}.", 
            playerName, playerLives, inicialPoints));
        Debug.Log($"You have to reach {finalPoints} to win");
        
    }


   






}


