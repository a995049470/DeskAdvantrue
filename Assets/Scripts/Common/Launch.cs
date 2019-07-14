using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour 
{
    private void Awake()
    {
        //用LUA初始化GameConfigs
        LuaUtility.DoString("config.mapconfig");
        //初始化ModelCenter
        ModelCenter.Instance.Init();
    }
}
