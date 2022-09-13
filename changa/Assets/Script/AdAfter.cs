using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdAfter : MonoBehaviour
{
    [SerializeField] GameObject[] adView;
    int currentAd;
    int gamePlayNumber;

    private void Awake()
    {
        gamePlayNumber = PlayerPrefs.GetInt("gamePlayNumber");
    }

    public void CheckToShowAd()
    {
        gamePlayNumber++;
        if (gamePlayNumber >= 2)
        {
            gamePlayNumber = 0;
            PlayerPrefs.SetInt("gamePlayNumber", gamePlayNumber);
            RandomAd();
        }

      
        PlayerPrefs.SetInt("gamePlayNumber", gamePlayNumber);
    }


    public void RandomAd()
    {
        currentAd = Random.Range(0, adView.Length);
        adView[currentAd].SetActive(true);
    }


    public void CloseAd()
    {
        adView[currentAd].SetActive(false);
    }
}
