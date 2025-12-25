using ProcedureOwner = GameFramework.Fsm.IFsm<GameFramework.Procedure.IProcedureManager>;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameFramework;
using GameFramework.Procedure;
using GameFramework.Fsm;
using UnityGameFramework.Runtime;
using GameFramework.Resource;
using System.Resources;

public class ProcedurePreload : ProcedureBase
{
    cfg.TablesComponent tablesComponent;

    protected override void OnInit(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnInit(procedureOwner);
    }

    protected override void OnDestroy(ProcedureOwner procedureOwner)
    {
        base.OnDestroy(procedureOwner);
    }

    protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
    {
        base.OnEnter(procedureOwner);

        tablesComponent = GameEntry.GetComponent<cfg.TablesComponent>();
    }

    protected override void OnLeave(IFsm<IProcedureManager> procedureOwner, bool isShutdown)
    {
        base.OnLeave(procedureOwner, isShutdown);
    }

    protected override void OnUpdate(IFsm<IProcedureManager> procedureOwner, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);

        if (!tablesComponent || !tablesComponent.IsLoaded)
        {
            return;
        }

        Debug.Log("Load Luban finished");

        foreach (var item in tablesComponent.TbLayer.DataList)
        {
            Game.GameEntry.UI.AddUIGroup(item.GroupName, item.Order);
        }

        foreach (var item in tablesComponent.TbForm.DataList)
        {
            Debug.LogFormat("Luban ui form: {0}", item.ToString());
        }

        ChangeState<ProcedureMain>(procedureOwner);
    }
}
