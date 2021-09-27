using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
   float speed = 1.4f;

   double mana = 15.5; 

   int health = 100; 

   string playerName = "Warrior"; 

   bool isDead = true; // same as boolean type 

    private void Start()
    {
        // CaclulateTwoNumbers();
        // CaclulateTwoNumbers(30, 22);

        // float sum = ReturnTwoNumbers();
        // Debug.Log("the sum is " + sum); 

        // Debug.Log("the sum is: " = ReturnTwoNumbers(10, 20)); 

        // if (health == 0){
        //     Debug.Log("health is 0 and player has died")
        // } else if (health < 50) {

        // } else {

        // }

        switch (health) {
            case 100:
                Debug.Log("health is 100"); 
                break; 

            case 50: 
                Debug.Log("health is 50"); 
                break; 

            case 0: 
                Debug.Log("health is 0"); 
                break; 

            default: 
                Debug.Log("health is neither of the values above"); 
                break; 
        }
        
    }



    void CalculateTwoNumbers()
    { 

        float a = 10; 
        float b = 12;
        float c = a + b; 

        Debug.Log(a + " + " + b + " = " +  c);
        Debug.Log("the sum of a and b is: " + c); 
    }

    void CaclulateTwoNumbers(float a, float b) 
    {
        Debug.Log("the sum of a and b is: " + (a + b)); 
    }

    float ReturnTwoNumbers()
    {
        return 20 + 30; 
    }

    float ReturnTwoNumbers(float a, float b)
    {
        return a + b; 
    }



}
