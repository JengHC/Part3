using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager
{
    int _order = 0;

    Stack<UI_Popup> _popupStack = new Stack<UI_Popup>();

    public void SetCanvas(GameObject go, bool sort = true)
    {

    }

    public T SHowPopupUI<T>(string name = null) where T : UI_Popup
    {
        if (string.IsNullOrEmpty(name))
        {
            name = typeof(T).Name;
        }

        GameObject go = ProjectManager.Resource.Instantiate($"UI/Popup/{name}");
        T popup = Util.GetOrAddComponent<T>(go);
        _popupStack.Push(popup);
        return popup;
    }

    public void ClosePopupUI()
    {
        if (_popupStack.Count == 0)
        {
            return;
        }

        UI_Popup popup = _popupStack.Pop();
        ProjectManager.Resource.Destroy(popup.gameObject);
        popup = null;

        _order--;
    }

    public void ClosePopupUI(UI_Popup popup)
    {
        if(_popupStack.Count ==0)
        {
            return;
        }
        if (_popupStack.Peek() != popup)
        {
            Debug.Log("Close Popup Failed");
            return;
        }
        ClosePopupUI();
    }

    public void CloseAllPopupUI()
    {
        while(_popupStack.Count >0 )
        {
            ClosePopupUI();
        }
    }
}
