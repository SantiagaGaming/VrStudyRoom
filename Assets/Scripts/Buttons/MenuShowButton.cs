using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenuShowButton : BaseButton
{

    [SerializeField] private GameObject _showScreen;
    [SerializeField] private GameObject _hideScreen;
    public override void OnClicked(InteractHand interactHand)
    {
        base.OnClicked(interactHand);
        _showScreen.SetActive(true);
        _hideScreen.SetActive(false);

    }

}
