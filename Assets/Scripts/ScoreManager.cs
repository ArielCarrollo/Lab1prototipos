using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int ActualScore { get; set; }
    [SerializeField] private int HighScore { get; set; }
    public GameManager gameManager;

    private void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        ActualScore = 0;
        UI_Manager.Instance.UpdateText(ActualScore);
    }

    public void UpdateScore()
    {
        ActualScore++;
        UI_Manager.Instance.UpdateText(ActualScore);

        if (ActualScore > HighScore)
        {
            HighScore = ActualScore;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }

        gameManager.GenerarComida();
    }
}
