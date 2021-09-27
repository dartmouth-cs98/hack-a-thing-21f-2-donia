using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{

    int _health; 

    public int Health // another way of defining getters and setters
    {
        get{
            return _health; 
        }
        set{
            _health = value;
        }
    }

    int _power;

    public int Power // another way of defining getters and setters
    {
        get{
            return _power; 
        }
        set{
            _power = value;
        }
    } 

    string _name; 
    public string Name // another way of defining getters and setters
    {
        get{
            return _name; 
        }
        set{
            _name = value;
        }
    } 

    public Player() {

    }

    public Player(int health, int power, string name) {
        Health = health; 
        Power = power; 
        Name = name; 
    }

    public virtual void Attack(){
        Debug.Log("Player is attacking with fire."); 
    }

    public void Info(){
        Debug.Log("health is: " + Health); 
        Debug.Log("power is; " + Power); 
        Debug.Log("Name is: " + Name); 
    }

    // public void SetHealth(int health){
    //     this.health = health; 
    // }

    // public int GetHealth() {
    //     return health; 
    // }


} // class
