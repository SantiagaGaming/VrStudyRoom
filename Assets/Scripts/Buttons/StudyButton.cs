using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StudyButton : BaseButton
{
    public UnityAction<int> St�dyButonClicked;
    public override void OnClicked(InteractHand interactHand)
    {
        St�dyButonClicked?.Invoke(1);
        gameObject.SetActive(false);
    }
}
