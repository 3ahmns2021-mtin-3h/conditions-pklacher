using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{

    private int CTry;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        NumberCTry();
       /* if (VariableA && VariableB == true)
        {
            Debug.Log("A && B is true");
        }

        if (VariableB && VariableC == true)
        {
            Debug.Log("B && C is true");
        }

        if (VariableC && VariableD == true)
        {
            Debug.Log("C && D is true");
        }*/
    }

    private bool VariableA()
    {
        return false;
    }

    private bool VariableB()
    {
        return false;
    }

    private bool NumberC()
    {
        
         if (Input.GetKeyDown(KeyCode.Alpha1))
         {
            Debug.Log("1 pressed");
             if (Input.GetKeyDown(KeyCode.Alpha2))
             {
                Debug.Log("2 pressed");
                 if (Input.GetKeyDown(KeyCode.Alpha3))
                 {
                    Debug.Log("3 pressed");
                    if (Input.GetKeyDown(KeyCode.Alpha4))
                     {
                         Debug.Log("Variable C is right");
                         return true;
                     }
                 }
                 return false;
             }
             return false;
         }
         return false;
    }

    private void NumberCTry()
    {
        CTry = 0;
        Input.GetKeyDown(KeyCode.UpArrow)

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CTry = 1;
            Debug.Log("1 pressed");
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                CTry = 2;
                Debug.Log("2 pressed");
                if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    CTry = 3;
                    Debug.Log("3 pressed");
                    if (Input.GetKeyDown(KeyCode.Alpha4))
                    {
                        CTry = 4;
                        Debug.Log("Variable C is right");

                    }
                }

            }

        }
       
        
    }

 

    private bool VariableD()
    {
        return false;
    }
}



