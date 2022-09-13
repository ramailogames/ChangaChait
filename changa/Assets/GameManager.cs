using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameoverView;
    public bool hasGameStarted = false;
    public bool hasGameOver = false;

    [HideInInspector] public float playedTime = 0;
    public int scoreToAdd = 10;
    private void OnEnable()
    {
        playedTime = 0;
        scoreToAdd = 10;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (hasGameOver)
        {
            return;
        }

        playedTime += Time.deltaTime;
    }
    public void Invoke_ShowGameOver()
    {
        Invoke("ShowGameOver", .8f);
    }
    void ShowGameOver()
    {
        hasGameOver = true;
        FindObjectOfType<AdAfter>().CheckToShowAd();
        gameoverView.SetActive(true);
    }
}
