using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreButton : MonoBehaviour
{
    public int score;


    // Start is called before the first frame update
    void Awake()
    {
        Button scoreButton = gameObject.GetComponent<Button>();
        scoreButton.onClick.AddListener(PointUp);
    }

    public void PointUp()
    {
        score++;
        Debug.Log($"score : {score}");
    }

}
