using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyGameManager : MonoBehaviour
{
    static FlappyGameManager gameManager;

    public static FlappyGameManager Instance
    {
        get { return gameManager; }
    }

    FlappyUIManager flappyUiManager;
    public FlappyUIManager UiManager { get { return flappyUiManager; } }

    private int currentScore = 0;

    public int Score { get { return currentScore; } }

    // 최고 점수
    int bestScore = 0;
    public int BestScore { get => bestScore; }

    // PlayerPrefs (데이터 저장) 용 key string
    private const string FlappyBestScoreKey = "FlappyBestScore";


    // 게임 오버 처리를 위한 변수
    private bool isGameOver = true;
    public void SetGameOver(bool value) => isGameOver = value;

    private void Awake()
    {
        gameManager = this;
        flappyUiManager = FindObjectOfType<FlappyUIManager>();
    }

    private void Start()
    {
        flappyUiManager.UpdateScore(0);

        // 게임 시작 시, 저장 데이터가 있다면, 불러오고,
        // 없으면, default = 0
        bestScore = PlayerPrefs.GetInt(FlappyBestScoreKey, 0);
    }

    private void Update()
    {
        if (isGameOver)
        {
            Time.timeScale = 0f;
            return;
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        FlappyUIManager.Instance.SetScoreUI();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Restart()
    {
        int childCount = transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }

        isGameOver = false;
        Time.timeScale = 1f;
    }

    public void AddScore(int score)
    {
        currentScore += score;

        Debug.Log("Score: " + currentScore);

        flappyUiManager.UpdateScore(currentScore);
    }

    void UpdateScore()
    {
        if (bestScore < currentScore)
        {
            Debug.Log("최고 점수 갱신");
            bestScore = currentScore;

            PlayerPrefs.SetInt(FlappyBestScoreKey, bestScore);
        }
    }
}
