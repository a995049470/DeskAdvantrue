using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class T_1 : MonoBehaviour 
{
    [SerializeField] string m_FilePath;
    private LuaTable m_Table;

    private void Awake()
    {
        m_Table = LuaUtility.GetNewLuaTable();
        LuaTable newTable = LuaUtility.GetNewLuaTable();
        newTable.Set<string,LuaTable>("__index", LuaUtility.Global);
        m_Table.SetMetaTable(newTable);
        newTable.Dispose();
        LuaUtility.DoString(m_FilePath, this.gameObject.name, m_Table);

        Debug.Log(0x01);
    }
}
