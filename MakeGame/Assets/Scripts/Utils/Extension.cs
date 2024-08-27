using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public static class Extension 
{
    public static void AddUIEvent(this GameObject go, Action<PointerEventData> action, Define.UIEvnet type = Define.UIEvnet.Click)
    {
        UI_Base.AddUIEvent(go, action, type);
    }
}
