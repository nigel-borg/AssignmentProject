﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
public float speed = 20f;
public float jumpSpeed = 8f;
private float movement = 0f;

private Rigidbody2D rigidBody;
  // Use this for initialization
void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
}

  // Update is called once per frame
void Update () 
  {
    movement = Input.GetAxis ("Horizontal");// moves left and right of the sprite
    if (movement > 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    }
    else if (movement < 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    } 
    else {
    rigidBody.velocity = new Vector2 (0,rigidBody.velocity.y);
    }

    if(Input.GetKey (KeyCode.UpArrow)){// moves up the sprite 
      rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);
    }
    


    
  }

  void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Die")
        {
          SceneManager.LoadScene(2);
        } 
}


}
