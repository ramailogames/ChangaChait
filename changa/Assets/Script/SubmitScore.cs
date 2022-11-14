using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmitScore : MonoBehaviour
{
    private void OnEnable()
    {
        RamailoGamesApiHandler.SubmitScore(FindObjectOfType<GameManager>().playedTime);
        Ad();

    }

    private void Ad()
    {
        FindObjectOfType<JsFuncManager>().CreateAd();
        FindObjectOfType<JsFuncManager>().CreateAd();
    }


}
