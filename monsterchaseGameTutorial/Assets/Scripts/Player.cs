using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f; 
    [SerializeField]
    private float jumpForce = 11f; 

    private float movementX; 

    [SerializeField]
    private Rigidbody2D myBody; 
    private SpriteRenderer sr; 

    private Animator anim; 
    private string WALK_ANIMATION = "Walk"; 

    private bool isGrounded = true; 
    private string GROUND_TAG = "Ground"; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>(); 
        anim = GetComponent<Animator>(); 
        
        sr = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoveKeyboard(); 
        AnimatePlayer(); 

    }

    private void FixedUpdate() // usually for physics changes
    {
        PlayerJump(); 
    }

    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal"); 
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce; 
    }

    void AnimatePlayer()
    {
        // walk right
        if (movementX > 0){
            anim.SetBool(WALK_ANIMATION, true); 
            sr.flipX = false; 
        } else if (movementX < 0){ // moving left
            anim.SetBool(WALK_ANIMATION, true); 
            sr.flipX = true; 
        } else{ // idle
            anim.SetBool(WALK_ANIMATION, false); 
        }
        
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded) { // platform neutral 
            isGrounded = false; 
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse); 
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GROUND_TAG)) {
            isGrounded = true; 
        }
    }

}
