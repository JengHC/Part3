using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Button : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _text;

    int _score = 0;

    public void OnButtonClicked()
    {
        //Debug.Log("ButtonClicked");

        _score++;
        _text.text = $"Á¡¼ö : {_score}";
    }
}
