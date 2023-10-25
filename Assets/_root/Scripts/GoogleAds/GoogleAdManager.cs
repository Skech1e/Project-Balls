using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using System;
using TMPro;

public class GoogleAdManager : MonoBehaviour
{
    public static GoogleAdManager instance { get; private set; }

    public const string interstitial = "ca-app-pub-3940256099942544/1033173712";
    public const string banner = "ca-app-pub-3940256099942544/6300978111";

    BannerView bannerAd;
    InterstitialAd _interstitialAd;
    public TextMeshProUGUI status;

    AdRequest adRequest = new();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Destroy(this);
    }

    private IEnumerator Start()
    {
        List<string> devices = new()
        {
            AdRequest.TestDeviceSimulator, "347e60922d62406ab6eed7a07a28e7db", "2f3637ba2a884af4b8ecd4cae63cc156"
        };
        status.text = "Pre Request";
        //RequestConfiguration config = new RequestConfiguration.Builder().SetTestDeviceIds(devices).build();
        RequestConfiguration config = new(); config.TestDeviceIds = devices;
        status.text = "test devices added";
        MobileAds.SetRequestConfiguration(config);
        status.text = "Pre Init";
        MobileAds.Initialize((_) => MobileAdsEventExecutor.ExecuteInUpdate(() =>
        {
            status.text = "Initialized";
        }));
        yield return new WaitForSeconds(1f);
        status.text = "urmom";

        //PreloadBanner();
        //PreloadInterstitial();
    }

    #region Interstitial

    public void PreloadInterstitial()
    {
        DestroyInterstitial();
        InterstitialAd.Load(interstitial, adRequest, (InterstitialAd ad, LoadAdError error) =>
        {
            if (error != null || ad == null)
            {
                //ad failed
                return;
            }
            _interstitialAd = ad;

            ad.OnAdFullScreenContentClosed += () =>
            {
                DestroyInterstitial();
                PreloadInterstitial();
            };

        });
    }

    void DestroyInterstitial()
    {
        if (_interstitialAd != null)
            _interstitialAd.Destroy();
    }

    public void ShowInterstitial()
    {
        if (_interstitialAd != null && _interstitialAd.CanShowAd())
            _interstitialAd.Show();
    }
    #endregion

    #region Banner
    public void PreloadBanner()
    {
        DestroyBanner();
        bannerAd = new(banner, AdSize.Banner, AdPosition.Bottom);
        bannerAd.LoadAd(adRequest);
        bannerAd.OnBannerAdLoaded += () => { status.text = "Loaded"; };
        Action<LoadAdError> value = (_) => { status.text = "Error"; };
        bannerAd.OnBannerAdLoadFailed += value;
    }

    private void DestroyBanner()
    {
        if (bannerAd != null) bannerAd.Destroy();
    }
    #endregion
}
