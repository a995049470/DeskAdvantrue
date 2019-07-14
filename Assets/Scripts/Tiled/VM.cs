using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Instruction
{
    INST_END = 0x00,//结束指令
    INST_OUTPUT_TILED = 0x01,//生成地块
    INST_GET_TILED,//获取地块
    INST_GET_UNIT,//获取单位
    INST_SET_UNIT,//设置单位属性
}

public class VM : Single<VM>
{
    private GameObject m_TiledRoot;
    public VM()
    {
        m_TiledRoot = new GameObject();
        m_TiledRoot.name = "TiledRoot";
    }

    public void AchieveUnitBytecodes(Unit unit)
    {

    }

    public void INST_OUTPUT_TILED(int id, int x, int y, int z)
    {

    }
}
