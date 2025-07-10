using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker
{
    private int score;

    public void AddPoints(int points)
    {
        if (points > 0)
        {
            score += points;
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void ResetScore()
    {
        score = 0;
    }
}

