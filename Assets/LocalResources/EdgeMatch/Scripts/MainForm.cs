using Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainForm : AExUGuiForm
{
    override protected void OnOpen(object userData)
    {
        base.OnOpen(userData);

        Debug.LogFormat("MainForm OnOpen");
    }
}
