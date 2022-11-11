using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : BaseButton
{
    public override void OnClicked(InteractHand interactHand)
    {
        Application.Quit();
    }
}
