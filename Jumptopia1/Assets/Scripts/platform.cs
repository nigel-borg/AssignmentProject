﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float speed=10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x,transform.position.y-0.08f),0.1f);
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
