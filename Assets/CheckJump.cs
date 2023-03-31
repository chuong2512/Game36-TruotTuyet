using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckJump : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (GameUI.Instance.currentState != State.Stop)
        {
            GameUI.Instance.SetState(State.Running);
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (GameUI.Instance.currentState != State.Stop)
        {
            GameUI.Instance.SetState(State.Jumping);
        }
    }
}