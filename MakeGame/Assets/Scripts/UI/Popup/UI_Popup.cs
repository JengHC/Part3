using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Popup : UI_Base
{
    public virtual void Init()
    {
        ProjectManager.UI.SetCanvas(gameObject, true);
    }

    public virtual void ClosePopupUI()
    {
        ProjectManager.UI.ClosePopupUI(this);
    }
}
