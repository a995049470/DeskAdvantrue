using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit 
{
    public int[] Bytecodes;
    public Unit(int[] _bytecodes)
    {
        Bytecodes = _bytecodes;
    }
    
}
