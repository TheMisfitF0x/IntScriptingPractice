using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FMoveCommand : FCommand
{
    public Vector3 moveDirection;
    public FMoveCommand(Vector3 direction)
    {
        type = FCommandType.Move;

        moveDirection = direction;
    }
}
