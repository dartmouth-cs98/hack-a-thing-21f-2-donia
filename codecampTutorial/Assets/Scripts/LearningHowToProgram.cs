using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour 
{
    private Rigidbody2D myBody; 
    private BoxCollider2D myCollider; 
    private AudioSource audioSource; 
    private Animator anim; 

    private Transform myTransform; 

    Player p = new Player(); 

    private void Start()
    {
        myBody = GetComponent<Rigidbody2D>(); 
        audioSource = GetComponent<AudioSource>(); 

        audioSource.Play(); 

        myTransform = transform; 

        myTransform.position = new Vector3(10, 20, 30); 



    }


}