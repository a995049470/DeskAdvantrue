using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleMonoBehaviour<T> : MonoBehaviour 
{
    private static T m_Instance;
    private static GameObject m_Go;
    public static T Instance
    {
        get
        {
            if(m_Instance == null)
            {
                if(m_Go == null)
                {
                    m_Go = new GameObject();
                    m_Go.name = "SingleMonoBehaviour";

                }
            }
            return m_Instance;
        }
    }
	
}
