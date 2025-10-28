using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;

    public static GameManager Instance
    {
        get { return gameManager; }
    }

    FlappyUIManager flappyUiManager;
    public FlappyUIManager UiManager { get { return flappyUiManager; } }

    private int currentScore = 0;

    private void Awake()
    {
        gameManager = this;
        flappyUiManager = FindObjectOfType<FlappyUIManager>();
    }

    private void Start()
    {
        flappyUiManager.UpdateScore(0);
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        flappyUiManager.SetRestart();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddScore(int score)
    {
        currentScore += score;

        Debug.Log("Score: " + currentScore);

        flappyUiManager.UpdateScore(currentScore);
    }
}
