using System.Collections;
using System.Collections.Generic;
using UIFrameWord.UI;
using UnityEngine;

public class UITestPage : TTUIPage {
    public UITestPage()
        : base(UIType.Normal, UIMode.HideOther, UICollider.None)
    {
        uiPath = "UI/panel/main/uimain";
        //int i = 5;

    }

    public override void Awake(GameObject go)
    {
    }
}
