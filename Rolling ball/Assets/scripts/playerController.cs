﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("pickUps"))
        {
            other.gameObject.SetActive(false);
        }
    }


}
