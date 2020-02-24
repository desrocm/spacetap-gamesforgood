﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{

    public float speed;
    public float upDownSpeed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MovePipe();
        InvokeRepeating("SwitchUpDown", 0.1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SwitchUpDown()
    {
        upDownSpeed = -upDownSpeed;
        rb.velocity = new Vector2(-speed, upDownSpeed);
    }
    void MovePipe()
    {
        rb.velocity = new Vector2(-speed, upDownSpeed);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "PipeRemover")
        {
            Destroy(gameObject);
        }
    }
}
