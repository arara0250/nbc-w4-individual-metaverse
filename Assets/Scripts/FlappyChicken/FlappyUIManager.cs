using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using static StackUIManager;

public class FlappyUIManager : MonoBehaviour
{
    public enum FlappyUIState
    {
        Home,
        Game,
        Score,
    }

    static FlappyUIManager instance;
    public static FlappyUIManager Instance
    {
        get { return instance; }
    }

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;

    FlappyUIState currentState = FlappyUIState.Home;

    FlappyHomeUI homeUI = null;

    FlappyGameUI gameUI = null;

    FlappyScoreUI scoreUI = null;

    FlappyGameManager flappyChicken = null;

    private void Awake()
    {
        instance = this;
        flappyChicken = FindObjectOfType<FlappyGameManager>();

        homeUI = GetComponentInChildren<FlappyHomeUI>(true);
        homeUI?.Init(this);
        gameUI = GetComponentInChildren<FlappyGameUI>(true);
        gameUI?.Init(this);
        scoreUI = GetComponentInChildren<FlappyScoreUI>(true);
        scoreUI?.Init(this);

        ChangeState(FlappyUIState.Home);
    }

    void Start()
    {
        if (restartText == null)
            Debug.LogError("restartText is null!");

        if (scoreText == null)
            Debug.LogError("scoreText is null!");

        restartText.gameObject.SetActive(false);
    }

    public void SetRestart()
    {
        restartText.gameObject.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }

    public void ChangeState(FlappyUIState state)
    {
        currentState = state;
        homeUI?.SetActive(currentState);
        gameUI?.SetActive(currentState);
        scoreUI?.SetActive(currentState);
    }

    public void OnClickStart()
    {
        flappyChicken.Restart();
        ChangeState(FlappyUIState.Game);
    }

    public void OnClickExit()
    {
#if UNITY_EDITOR
        //UnityEditor.EditorApplication.isPlaying = false;
        flappyChicken.SetGameOver(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
#else
        //Application.Quit(); // 어플리케이션 종료
#endif
    }

    public void UpdateScore()
    {
        gameUI.SetUI(flappyChicken.Score);
    }

    public void SetScoreUI()
    {
        scoreUI.SetUI(flappyChicken.Score, flappyChicken.BestScore);

        ChangeState(FlappyUIState.Score);
    }
}
