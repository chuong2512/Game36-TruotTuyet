using System;
using System.Collections;
using System.Collections.Generic;
using TruotTuyet;
using Sirenix.OdinInspector;
using UnityEngine;

public class Player : Singleton<Player>
{
    public Animator animator;

    public Rigidbody2D rigidbody2D;

    private void OnValidate()
    {
        rigidbody2D = GetComponentInChildren<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float force = 1;
    
    [Button]
    public void Jump()
    {
        rigidbody2D.AddForce(Vector2.up * force);
        animator.SetTrigger("Jump");
    }
}
