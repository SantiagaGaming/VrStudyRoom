using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelloScenarioStep : ScenarioStep
{
    [SerializeField] private Loader _loader;
    [SerializeField] private GameObject _inputScenarioHelper;

    protected override void CheckActions(int number)
    {
      if(number ==0)
        {
            Player.Instance.CanMove = false;
            GamePanelView.Instance.SetHeaderText(textHolder.HelloHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.HelloDescription);
            teleportController.TeleportToStartPosition();
            _loader.StartLoading(1);
        }
      else if(number==1)
        {
            GamePanelView.Instance.SetDescriptionText(textHolder.HelloDescription2);
            _loader.StartLoading(2);
        }
        else if (number == 2)
        {
            Player.Instance.CanMove = true;
            _inputScenarioHelper.SetActive(true);
            if (modeController.IsDesktopMode())
                _inputScenarioHelper.GetComponent<Collider>().enabled = false;
            helpInputObject.ShowInput();
            GamePanelView.Instance.EnableActionTextObject(true);
            GamePanelView.Instance.SetHeaderText(textHolder.InputHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.InputTextDescription);
            GamePanelView.Instance.SetActionText(textHolder.InputTextAction);
        }
        else if (number == 3)
        {
            EndScenarioStepEvent?.Invoke();
        }
    }


}
