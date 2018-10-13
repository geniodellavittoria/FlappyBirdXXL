using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour
{
    public float upForce = 200f;                   //Upward force of the "flap".
    private bool isDead = false;            //Has the player collided with a wall?
    private Rigidbody2D rb2d;               //Holds a reference to the Rigidbody2D component of the bird.
    private Animator anim;

    void Start()
    {
        //Get and store a reference to the Rigidbody2D attached to this GameObject.
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //Don't allow control if the bird has died.
        if (isDead == false)
        {
            //Look for input to trigger a "flap".
            if (Input.GetMouseButtonDown(0))
            {
                //...zero out the birds current y velocity before...
                rb2d.velocity = Vector2.zero;

                //..giving the bird some upward force.
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        GameControl.instance.BirdDied();
    }
}

   