using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static StackUIManager;

public class StackScoreUI : StackBaseUI
{
    TextMeshProUGUI scoreText;
    TextMeshProUGUI comboText;
    TextMeshProUGUI bestScoreText;
    TextMeshProUGUI bestComboText;

    Button retryButton;
    Button exitButton;

    protected override StackUIState GetUIState()
    {
        return StackUIState.Score;
    }

    public override void Init(StackUIManager uiManager)
    {
        base.Init(uiManager);

        scoreText = transform.Find("ScoreText").GetComponent<TextMeshProUGUI>();
        comboText = transform.Find("ComboText").GetComponent<TextMeshProUGUI>();
        bestScoreText = transform.Find("BestScoreText").GetComponent<TextMeshProUGUI>();
        bestComboText = transform.Find("BestComboText").GetComponent<TextMeshProUGUI>();
        retryButton = transform.Find("RetryButton").GetComponent<Button>();
        exitButton = transform.Find("ExitButton").GetComponent<Button>();

        retryButton.onClick.AddListener(OnClickStartButton);
        exitButton.onClick.AddListener(OnClickExitButton);
    }

    public void SetUI(int score, int combo, int bestScore, int bestCombo)
    {
        scoreText.text = score.ToString();
        comboText.text = combo.ToString();
        bestScoreText.text = bestScore.ToString();
        bestComboText.text = bestCombo.ToString();
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
