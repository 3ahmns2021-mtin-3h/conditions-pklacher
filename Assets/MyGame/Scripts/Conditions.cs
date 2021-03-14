using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
    private bool variableA = false;
    //four numbers greater than five
    private bool variableB = false;
    //Spacebar pressed for 3sec
    private bool variableC = false;
    //numbers 1-4 pressed
    private bool variableD = false;
    //

    private bool numberOne = false;
    private bool numberTwo = false;
    private bool numberThree = false;
    private bool numberFour = false;


    private float time;

    public GameObject button;


    // Update is called once per frame
    void Update()
    {
        if ((variableA && variableB || variableB && variableC || variableC && variableD))
        {
            Debug.Log("conditions completed");
        }
        else
        {
            Debug.Log("conditions not completed");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            time += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space)){
            time = 0;
        }

        if (time >= 3)
        {
            variableB = true;
            Debug.Log("Variable B true");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            numberOne = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            numberTwo = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            numberThree = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            numberFour = true;
        }

        if (numberOne && numberTwo && numberThree && numberFour)
        {
            variableC = true;
            Debug.Log("Variable C true");
        }

        if (button.activeInHierarchy == false)
        {
            Debug.Log("Variable D true");
            variableD = true;
        }

        RandomNumbers();
    }


    public void RandomNumbers()
    {
        int greaterFive = 0;

        for (int i = 0; i < 10; i++)
        {
            int rnd = Random.RandomRange(1, 11);
            if (rnd > 5)
            {
                greaterFive++;
            }
        }
        if (greaterFive >= 4)
        {
            variableA = true;
            Debug.Log("Variable A true");
        }
    }


}



