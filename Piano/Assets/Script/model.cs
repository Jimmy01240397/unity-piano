using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class model : MonoBehaviour
{
    public string currentModel = "Model1";
    public bool isModel1Selected = true;
    public TextMeshProUGUI modelNameText;

    public void OnClick()
    {
        SwitchModel();
    }

    private void SwitchModel()
    {
        isModel1Selected = !isModel1Selected;

        currentModel = isModel1Selected ? "Model1" : "Model2";
        string displayName = isModel1Selected ? "Oriental " : "Pop";

        modelNameText.text = displayName;

        // ��L�ާ@�A�Ҧp�N�ҿ�ҫ��W�ٵo�e��Python�A�Ⱦ�
    }
}
