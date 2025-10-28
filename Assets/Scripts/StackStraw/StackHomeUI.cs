using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static StackUIManager;

public class StackHomeUI : StackBaseUI
{
    Button startButton;
    Button exitButton;

    protected override StackUIState GetUIState()
    {
        return StackUIState.Home;
    }

    public override void Init(StackUIManager uiManager)
    {
        base.Init(uiManager);

        startButton = transform.Find("StartButton").GetComponent<Button>();
        exitButton = transform.Find("ExitButton").GetComponent<Button>();

        startButton.onClick.AddListener(OnClickStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    void OnClickStartButton()
    {
        stackUIManager.OnClickStart();
    }

    void OnClickExitButton()
    {
        stackUIManager.OnClickExit();
    }
}
