using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.RotateAround(ScoringManager.SINGLETON.currentPlatform.transform.position, new Vector3(0, 1, 0), ScoringManager.SINGLETON.currentPlayerRotationSpeed * Time.deltaTime);
        rb.MovePosition(transform.position += transform.rotation * new Vector3(1, 0, 0) * ScoringManager.SINGLETON.playerSpeed * Time.deltaTime);
        
    }
    
}
