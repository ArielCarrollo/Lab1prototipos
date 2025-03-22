using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewScoreData", menuName = "ScriptableObjects/ScoreData")]
public class ScoreData : ScriptableObject
{
    public int ActualScore;
    public int HighScore;

    public void ResetScore()
    {
        ActualScore = 0;
    }

    public void UpdateHighScore()
    {
        if (ActualScore > HighScore)
        {
            HighScore = ActualScore;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
    }

    public void LoadHighScore()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0);
    }
}

