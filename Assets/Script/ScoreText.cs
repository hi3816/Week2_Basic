using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreButton.onScoreChanged += RefreshUI;

    }

    void RefreshUI(int score) 
    {
        scoreText.text = score.ToString();
    }

}
