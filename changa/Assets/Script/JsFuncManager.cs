using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class JsFuncManager : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void openAd();


    public void CreateAd() // On Create Ad Button
    {
        openAd();
    }
}
