using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lin.UI;
using XLua;
using System;

public class LuaWindow : Window
{
    [SerializeField] string m_FilePath;
    private Action bindController;
    private Action addListeners;
    private Action onPerOpen;
    private Action onAfterOpen;
    private Action onPerClose;
    private Action onAfterClose;
    private LuaTable m_Table;
	
    private void Init()
    {
        m_Table = LuaUtility.GetNewLuaTable();
        LuaTable temp = LuaUtility.GetNewLuaTable();
        temp.Set<string, LuaTable>("__index", LuaUtility.Global);
        m_Table.SetMetaTable(temp);
        temp.Dispose();
        LuaUtility.DoString(m_FilePath, this.gameObject.name, m_Table);
        m_Table.Get<string, Action>("BindController", out bindController);
        m_Table.Get<string, Action>("AddListeners", out addListeners);
        m_Table.Get<string, Action>("OnPerOpen", out onPerOpen);
        m_Table.Get<string, Action>("OnAfterOpen", out onAfterOpen);
        m_Table.Get<string, Action>("OnPerClose", out onPerClose);
        m_Table.Get<string, Action>("OnAfterClose", out onAfterClose);
    }

    protected override void BindController()
    {
        base.BindController();
        Init();
        if(bindController != null)
        {
            bindController();
        }
    }

    protected override void AddListeners()
    {
        base.AddListeners();
        if(addListeners != null)
        {
            addListeners();
        }
    }

    protected override void OnPerOpen()
    {
        base.OnPerOpen();
        if(onPerOpen != null)
        {
            onPerOpen();
        }
    }

    protected override void OnAfterOpen()
    {
        base.OnAfterOpen();
        if(onAfterOpen != null)
        {
            onAfterOpen();
        }
    }

    
}
