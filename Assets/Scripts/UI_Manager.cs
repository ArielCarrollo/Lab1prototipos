using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    // Singleton
    public static UI_Manager Instance;

    // Atributos p�blicos
    public Text ActualScoreText;
    public Text HighScoreText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // M�todo p�blico: Actualiza los textos de la interfaz
    public void UpdateText(int actualScore)
    {
        ActualScoreText.text = "Score: " + actualScore;
        HighScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0);
    }
}
