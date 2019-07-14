using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[XLua.LuaCallCSharp]
public class GameConfigs : Single<GameConfigs> 
{
    public Dictionary<int, int[]> TiledConfigs { get; set; }

}
