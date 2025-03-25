using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UI_Manager : SingletonPersistent<UI_Manager>
{
    public TMP_Text ActualScoreText;
    public TMP_Text HighScoreText;
    [SerializeField] private GameObject DeathPanel;
    [SerializeField] private ScoreData scoreData;
    private void Start()
    {
        DeathPanel.SetActive(false);
    }
    public void UpdateText(int actualScore)
    {
        ActualScoreText.text = "Score: " + actualScore;
        HighScoreText.text = "High Score: " + scoreData.HighScore;
    }
    public void DeathScreen(bool death)
    {
        if(death == true)
        {
            DeathPanel.SetActive(true);
            Time.timeScale = 0.0f;
        } 
    }
    public void Restart()
    {
        DeathPanel.SetActive(false);
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
