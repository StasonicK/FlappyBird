using System;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _bird.ScoreChanged += ScoreChanged;
    }

    private void OnDisable()
    {
        _bird.ScoreChanged -= ScoreChanged;
    }

    private void ScoreChanged(int score)
    {
        _score.text = score.ToString();
    }
}