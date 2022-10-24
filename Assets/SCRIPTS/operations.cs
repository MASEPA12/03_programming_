using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operations : MonoBehaviour
{
    public int R = 7;
    public int Q = 4;
    public float result;
    
    // Start is called before the first frame update
    void Start()
    {
        //+
        result = R + Q;
        Debug.Log(string.Format(
            "The sum of {0} and {1} is {2}.", R, Q, result));

        //-
        result = R - Q;
        Debug.Log(string.Format(
            "The substraction of {0} and {1} is {2}.", R, Q, result));


        // DIVISION  
        result = (float)R / Q;
        Debug.Log(string.Format(
            "The quotient of {0} and {1} is {2}.", R, Q, result ));

        //PRODUCT
        Debug.Log(string.Format(
            "The product of {0} and {1} is {2}", R, Q, R * Q));

        //MODULE
        Debug.Log(string.Format(
            "The module of {0} and {1} is {2}", R, Q, R % Q));
       
    }

   
}
