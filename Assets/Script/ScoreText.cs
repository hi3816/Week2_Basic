using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreButton scoreButton;
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreButton.button.onClick.AddListener(RefreshUI);
    }

    void RefreshUI() 
    {
        scoreText.text = scoreButton.score.ToString();
    }

}
