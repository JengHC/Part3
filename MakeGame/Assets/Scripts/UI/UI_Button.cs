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

        //Get<TextMeshProUGUI>((int)Texts.ScoreText).text = "Bind Test";

        GetButton((int)Buttons.PointButton).gameObject.AddUIEvent(OnButtonClicked);
        
        GameObject go = GetImage((int)Images.ItemIcon).gameObject;
        AddUIEvent(go, (PointerEventData data) => { go.transform.position = data.position; },Define.UIEvnet.Drag);
    }

    int _score = 0;

    public void OnButtonClicked(PointerEventData data)
    {
        _score++;
        //_text.text = $"점수 : {_score}";
        Get<TextMeshProUGUI>((int)Texts.ScoreText).text = $"점수 : {_score}";
    }
}
