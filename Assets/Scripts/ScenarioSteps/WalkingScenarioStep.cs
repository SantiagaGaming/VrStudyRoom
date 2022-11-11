using AosSdk.Core.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingScenarioStep : ScenarioStep
{
    [SerializeField] private GameObject _carpet1;
    [SerializeField] private GameObject _carpet2;
    protected override void CheckActions(int number)
    {
        if (number == 0)
        {
            Player.Instance.CanMove = true;
            teleportController.TeleportToStartPosition();
            GamePanelView.Instance.SetHeaderText(textHolder.WalkingHeader);
            GamePanelView.Instance.SetDescriptionText(textHolder.MovingTextDescription);
            GamePanelView.Instance.EnableActionTextObject(true);
            GamePanelView.Instance.SetActionText(textHolder.MovingTextAction1);
            _carpet1.GetComponent<Collider>().enabled = true;
            helpInputObject.ShowMovingHelp();
            outlineContainer.OutlineObject("Ñarpet1");
        }
        else if(number == 1)
        {
            canvasPositionChanger.ChangeCanvasPositionToCarpet1();
            outlineContainer.HideAllOutLines();
            GamePanelView.Instance.SetDescriptionText("");
            GamePanelView.Instance.SetActionText(textHolder.MovingTextAction2);
            _carpet1.GetComponent<Collider>().enabled = false;
            _carpet2.GetComponent<Collider>().enabled = true;
            outlineContainer.OutlineObject("Carpet2");
        }
        else if(number ==2)
        {
            _carpet2.GetComponent<Collider>().enabled = false;
            outlineContainer.HideAllOutLines();
            helpInputObject.Hide();
            EndScenarioStepEvent?.Invoke();
        }
    }
}
