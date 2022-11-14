using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAd : MonoBehaviour
{

    private void OnEnable()
    {
        Ad();
    }

    private void Ad()
    {
        FindObjectOfType<JsFuncManager>().CreateAd();
        FindObjectOfType<JsFuncManager>().CreateAd();
    }

    private void Start()
    {
        Invoke("Ad", 1f);
    }
}
