using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FAttackCommand : FCommand
{
    public FAttackCommand()
    {
        type = FCommandType.Attack;
    }
}
