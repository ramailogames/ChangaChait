using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    float currentScore = 0;
    float highScore = 0;

    [SerializeField] TextMeshProUGUI currentScoreTxt;
    [SerializeField] TextMeshProUGUI highScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        
        highScore = PlayerPrefs.GetFloat("highScore");

        currentScoreTxt.text = currentScore.ToString();
        highScoreTxt.text = highScore.ToString();
    }

    public void AddScore()
    {
        currentScore++;
        currentScoreTxt.text = currentScore.ToString("0");
    }

    public void SumbitScore()
    {
        if(currentScore < highScore)
        {
            return;
        }
        PlayerPrefs.SetFloat("highScore", currentScore);
        highScoreTxt.text = highScore.ToString();
    }


}
