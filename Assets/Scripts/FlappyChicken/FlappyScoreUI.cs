using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static FlappyUIManager;
using static StackUIManager;

public class FlappyScoreUI : FlappyBaseUI
{
    TextMeshProUGUI scoreText;
    TextMeshProUGUI bestScoreText;

    Button retryButton;
    Button exitButton;

    protected override FlappyUIState GetUIState()
    {
        return FlappyUIState.Score;
    }

    public override void Init(FlappyUIManager uiManager)
    {
        base.Init(uiManager);

        scoreText = transform.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        bestScoreText = transform.Find("BestScoreText").GetComponent<TextMeshProUGUI>();
        retryButton = transform.Find("RetryButton").GetComponent<Button>();
        exitButton = transform.Find("ExitButton").GetComponent<Button>();

        retryButton.onClick.AddListener(OnClickStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    public void SetUI(int score, int bestScore)
    {
        scoreText.text = score.ToString();
        bestScoreText.text = bestScore.ToString();
    }

    void OnClickStartButton()
    {
        flappyUIManager.OnClickStart();
    }

    void OnClickExitButton()
    {
        flappyUIManager.OnClickExit();
    }
}
