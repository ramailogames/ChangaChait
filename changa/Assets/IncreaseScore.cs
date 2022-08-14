using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    RamailoGamesScoreManager scoreManager;
    GameManager manager;


    private void Awake()
    {
        scoreManager = FindObjectOfType<RamailoGamesScoreManager>();
        manager = FindObjectOfType<GameManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("IncreaseScorePerX", 3f, 2f);
    }

    void IncreaseScorePerX()
    {

        if (manager.hasGameOver)
        {
            return;
        }
        scoreManager.AddScore(10f);
        
    }

}
