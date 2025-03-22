using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Atributos públicos
    public int ActualScore { get; private set; }
    public int HighScore { get; private set; }
    public GameManager gameManager;

    private void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
        ActualScore = 0;
        UI_Manager.Instance.UpdateText(ActualScore);
    }

    // Método público: Actualiza el puntaje y genera nueva comida
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
