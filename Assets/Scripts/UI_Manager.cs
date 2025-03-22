using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
public class UI_Manager : MonoBehaviour
{
    public static UI_Manager Instance;

    public TMP_Text ActualScoreText; 
    public TMP_Text HighScoreText; 

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

    public void UpdateText(int actualScore)
    {
        ActualScoreText.text = "Score: " + actualScore;
        HighScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0);
    }
}
