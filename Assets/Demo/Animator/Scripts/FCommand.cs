using System.Collections;
using System.Collections.Generic;

public abstract class FCommand
{
    public FCommandType type;
}

public enum FCommandType
{
    Move,
    Attack,
    Jump
}