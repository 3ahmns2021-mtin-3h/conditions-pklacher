using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionsTwo : MonoBehaviour
{
    private bool SpacePressed = false;
    private float time;

    private bool spacePressed;
    private bool buttonPressed;
    private bool fourGreaterThanFive;
    private bool numbersPressed;

    private bool keyOne;
    private bool keyTwo;
    private bool keyThree;
    private bool keyFour;

    public void Update()
    {
        if ((spacePressed && buttonPressed) || (buttonPressed && fourGreaterThanFive) || (fourGreaterThanFive && numbersPressed))
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            time += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            time = 0;
        }
        if (time > 3)
        {
            spacePressed = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            keyOne = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            keyTwo = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            keyThree = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            keyFour = true;
        }

        if (keyOne && keyTwo && keyThree && keyFour)
        {
            numbersPressed = true;
        }
    }

    public void ButtonPressed()
    {
        buttonPressed = true;
    }

    public void GenerateNumbers()
    {
        int numGreaterThanFive = 0;

        for (int i = 1; i <= 10; i++)
        {
            int number = Random.Range(1, 11);
            if (number > 5)
            {
                numGreaterThanFive++;
            }
        }

        if (numGreaterThanFive >= 4)
        {
            fourGreaterThanFive = true;
        }
    }
}