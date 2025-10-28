using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlappyUIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI restartText;

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
}
