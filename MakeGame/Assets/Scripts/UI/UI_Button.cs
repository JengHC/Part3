using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Button : UI_Base
{
    //[SerializeField]
    //TextMeshProUGUI _text;

    enum Buttons
    {
        PointButton
    }

    enum Texts
    {
        PointText,
        ScoreText,
    }

    enum GameObjects
    {
        TestObject,
    }

    enum Images
    {
        ItemIcon,
    }    

    private void Start()
    {
        Bind<Button>(typeof(Buttons));
        Bind<TextMeshProUGUI>(typeof(Texts));
        Bind<GameObject>(typeof(GameObjects));
        Bind<Image>(typeof(Images));

        Get<TextMeshProUGUI>((int)Texts.ScoreText).text = "Bind Test";

        GameObject go = GetImage((int)Images.ItemIcon).gameObject;
        UI_EventHandler evt = go.GetComponent<UI_EventHandler>();
        evt.OnDragHandler += ((PointerEventData data) => { evt.gameObject.transform.position = data.position; });
    }


    int _score = 0;

    public void OnButtonClicked()
    {
        _score++;
        //_text.text = $"���� : {_score}";
        //Get<TextMeshPro>((int)Texts.ScoreText).text = $"���� : {_score}";
    }
}
