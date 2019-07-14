using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;
using System;
using System.IO;

public class LuaUtility : SingleMonoBehaviour<LuaUtility> 
{
    public static readonly LuaEnv MyEnv;
    private static float m_LastGCTime;
    private static float m_GCInterval = 1f;
    public static LuaTable Global
    {
        get
        {
            return MyEnv.Global;
        }
        
    }
    public static LuaTable GetNewLuaTable()
    {
        return MyEnv.NewTable();
    }

    static LuaUtility()
    {
        MyEnv = new LuaEnv();
        m_LastGCTime = 0;
    }
    public static void Do(string _file, string chunckName = "chunk", LuaTable _table = null)
    {
        string chunk = string.Format("require '{0}'", _file);
        MyEnv.DoString(chunk, chunckName, _table);
    }
    public static void DoString(string _file, string chunkName = "chunk", LuaTable _table = null)
    {
        string chunk = LoadAsset(_file);
        MyEnv.DoString(chunk, chunkName, _table);
    }
    
    public static string LoadAsset(string file)
    {
        file = file.Replace('.', '/');
        string path = "";
        path = ResourcesPath.LuaPath + file + ".lua";
        string res = File.ReadAllText(path);       
        return res;
    }

}
