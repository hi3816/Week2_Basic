using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public int score;
    public Button button;
    public ScoreText scoreText;

    public Action<int> onScoreChanged;

    // Start is called before the first frame update
    void Awake()
    {
        button = gameObject.GetComponent<Button>();
        button.onClick.AddListener(PointUp);
    }

    public void PointUp()
    {
        score++;
        onScoreChanged?.Invoke(score);
    }

}
