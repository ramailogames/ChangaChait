using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
public class Inersitial : MonoBehaviour
{
    private InterstitialAd interstitial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        MobileAds.Initialize(initstatus => { });
        RequestInterstitial();

    }

    public void RequestAd_Interstitial()
    {
       

        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-2918125884829430/2148227283";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);
    }
}
