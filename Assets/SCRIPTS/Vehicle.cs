using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    //This function save the number of wheels of the vehicle
    [SerializeField] private int wheels = 4;
    [SerializeField] private string name;
   
    private void Start()
        {
        Debug.Log($"The {name} has {wheels} wheels");
    }   

}

