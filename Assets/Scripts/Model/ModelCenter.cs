using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelCenter : Single<ModelCenter> 
{
    private Dictionary<string, Model> m_ModelDic;
    
    public void Init()
    {
        m_ModelDic = new Dictionary<string, Model>();
        RegistereModel<MapModel>();
        foreach (var model in m_ModelDic.Values)
        {
            model.Init();
        }
    }
    public void RegistereModel<T>() where T : Model, new()
    {
        string key = typeof(T).ToString();
        if(m_ModelDic.ContainsKey(key))
        {
            return;
        }
        T value = new T();
        m_ModelDic[key] = value;
    }

    public T GetModel<T>() where T : Model, new()
    {
        string key = typeof(T).ToString();
        if(!m_ModelDic.ContainsKey(key))
        {
            RegistereModel<T>();
        }
        T value = m_ModelDic[key] as T;
        return value;
    }
    public Model GetModel(string key)
    {
        Model value = null;
        if(m_ModelDic.ContainsKey(key))
        {
            value = m_ModelDic[key];
        }
        return value;
    }

}
