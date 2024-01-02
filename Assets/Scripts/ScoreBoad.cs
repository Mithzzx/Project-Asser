using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoad : MonoBehaviour
{
    int score;

    [SerializeField] TMP_Text scoreText;

    private void Start()
    {
        scoreText.text = "Score";
    }

    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
        scoreText.text = score.ToString();
    }
}
