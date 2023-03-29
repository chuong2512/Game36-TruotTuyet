using System.Collections;
using System.Collections.Generic;
using JumpFrog;
using UnityEngine;

public class Player : Singleton<Player>
{
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jump()
    {
        animator.SetTrigger("Jump");
    }
}
