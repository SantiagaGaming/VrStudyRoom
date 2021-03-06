using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StudyButton : BaseButton
{
    public UnityAction<int> StudyButonClicked;
    public override void OnClicked(InteractHand interactHand)
    {
        StudyButonClicked?.Invoke(1);
        gameObject.GetComponent<Collider>().enabled = false;
    }
}
