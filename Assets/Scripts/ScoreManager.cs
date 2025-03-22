using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private ScoreData scoreData;
    public GameManager gameManager;

    private void Start()
    {
        scoreData.LoadHighScore();
        scoreData.ResetScore();
        UI_Manager.Instance.UpdateText(scoreData.ActualScore);
    }

    public void UpdateScore()
    {
        scoreData.ActualScore++;
        UI_Manager.Instance.UpdateText(scoreData.ActualScore);

        scoreData.UpdateHighScore();

        gameManager.GenerarComida();
    }
}

