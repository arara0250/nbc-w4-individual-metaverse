using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StackUIManager : MonoBehaviour
{
    public enum StackUIState
    {
        Home,
        Game,
        Score,
    }

    static StackUIManager instance;
    public static StackUIManager Instance
    {
        get { return instance; }
    }

    StackUIState currentState = StackUIState.Home;

    StackHomeUI homeUI = null;

    StackGameUI gameUI = null;

    StackScoreUI scoreUI = null;

    StackGameManager theStack = null;
    private void Awake()
    {
        instance = this;
        theStack = FindObjectOfType<StackGameManager>();

        homeUI = GetComponentInChildren<StackHomeUI>(true);
        homeUI?.Init(this);
        gameUI = GetComponentInChildren<StackGameUI>(true);
        gameUI?.Init(this);
        scoreUI = GetComponentInChildren<StackScoreUI>(true);
        scoreUI?.Init(this);

        ChangeState(StackUIState.Home);
    }


    public void ChangeState(StackUIState state)
    {
        currentState = state;
        homeUI?.SetActive(currentState);
        gameUI?.SetActive(currentState);
        scoreUI?.SetActive(currentState);
    }

    public void OnClickStart()
    {
        theStack.Restart();
        ChangeState(StackUIState.Game);
    }

    public void OnClickExit()
    {
#if UNITY_EDITOR
        //UnityEditor.EditorApplication.isPlaying = false;
        SceneManager.LoadScene("MainScene");
#else
        //Application.Quit(); // 어플리케이션 종료
#endif
    }

    public void UpdateScore()
    {
        gameUI.SetUI(theStack.Score, theStack.Combo, theStack.MaxCombo);
    }

    public void SetScoreUI()
    {
        scoreUI.SetUI(theStack.Score, theStack.MaxCombo, theStack.BestScore, theStack.BestCombo);

        ChangeState(StackUIState.Score);
    }
}
