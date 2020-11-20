using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jump();
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprint();
        }

    }          
   public void jump()
   {
    animator.SetTrigger("jump");
   }
   public void sprint() 
   {
      animator.SetTrigger("sprint");
   }

}