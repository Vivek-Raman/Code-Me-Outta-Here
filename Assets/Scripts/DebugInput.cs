
using System;
using UnityEngine;

public class DebugInput : MonoBehaviour
{
    private Movement mover;

    private void Awake()
    {
        mover = this.GetComponent<Movement>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            mover.Move(Direction.Up);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            mover.Move(Direction.Right);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            mover.Move(Direction.Down);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            mover.Move(Direction.Left);
        }
    }
}
