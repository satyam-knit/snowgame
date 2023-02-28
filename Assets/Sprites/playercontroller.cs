using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{ 
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float basespeed = 20f;

    Rigidbody2D rb2d;
    SurfaceEffector2D SurfaceEffector2D;
    bool canMove = true;
    
    void Start()
    {
     rb2d =  GetComponent<Rigidbody2D>();
     SurfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();

    }
    
    void Update() 
    {
        if (canMove)
        {
     RotatePlayer();  
      RespondToBoost();
        }
      
    }

    public void DisableControls()
    {
      canMove = false;
    }
     
    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            SurfaceEffector2D.speed = boostSpeed; 
        }
        else
        {
            SurfaceEffector2D.speed =  basespeed; 
        }

    }


     void RotatePlayer()
    {
        
       if (Input.GetKey(KeyCode.LeftArrow ))
       {
        rb2d.AddTorque(torqueAmount);
       }
      else if (Input.GetKey(KeyCode.RightArrow ))
       {
        rb2d.AddTorque(-torqueAmount);
       }
 
 
    }
}
