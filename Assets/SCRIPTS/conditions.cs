using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour
{
    public int x = 10;
    public int y = 4;
    private bool areEqual;

    public string name1 = "Eustaquio";
    public string name2 = "Celedonio";
    private bool areDifferent;

    public float a = 2.0f;
    public float b = 0.5f;
    private bool isGreater = true;

   //dia 24-10
    public bool isRaining;

      private void Start() {
        
        //operacions condicionals 
        Debug.Log(string.Format("{0} and {1} are equal", x, y));
        areEqual = x == y;
        Debug.Log(areEqual);

        Debug.Log(string.Format("{0} and {1} are different", name1, name2));
        areDifferent = name1 != name2;
        Debug.Log(areDifferent);

        Debug.Log(string.Format("Are you not Marina?"));
        Debug.Log(name1 != "Marina");

        Debug.Log(string.Format("{0} is grater than {1}",a,b));
        isGreater = a > b;
        Debug.Log(isGreater);

        Debug.Log(string.Format("{0} is smaller than {1}", a, b));
        isGreater = a < b;
        Debug.Log(isGreater);

        Debug.Log(string.Format("{0} is grater or equal than {1}", a, b));
        isGreater = a >= b;
        Debug.Log(isGreater);

        Debug.Log(string.Format("{0} is smaller or equal than {1}", a, b));
        isGreater = a <= b;
        Debug.Log(isGreater);
        

        //dia 24-10 --> condicionals amb IF
        if (isRaining == true)
        {
            Debug.Log("Remember grabing an umbrella");
        } 


    }    
}
