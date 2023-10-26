using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour, IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    public static AdManager instance { get; private set; }

    [SerializeField] string _androidGameId;
    [SerializeField] bool _testMode = true;

    public string _interstitial, _banner, _reward;
    public TextMeshProUGUI status;
    public bool AdsEnabled;
    BannerPosition _bannerPos = BannerPosition.BOTTOM_CENTER;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this);
    }

    private void Start()
    {
        if (AdsEnabled == false)
            return;
        InitializeAds();
        Advertisement.Banner.SetPosition(_bannerPos);
        LoadBanner();
        //yield return new WaitForSeconds(0.2f);
        ShowBanner();
        LoadInterstitial();
        //LoadReward();
    }

    public void InitializeAds()
    {
        if (!Advertisement.isInitialized && Advertisement.isSupported)
            Advertisement.Initialize(_androidGameId, _testMode, this);
    }

    void LoadBanner()
    {
        BannerLoadOptions bannerOptions = new BannerLoadOptions
        {
            loadCallback = () => { },
            errorCallback = OnBannerError
        };
        Advertisement.Banner.Load(_banner, bannerOptions);
        //status.text = "Banner Loaded";
    }

    private void OnBannerError(string message)
    {

    }

    public void ShowBanner()
    {
        BannerOptions options = new BannerOptions
        {
            clickCallback = OnBannerClicked,
            hideCallback = OnBannerHidden,
            showCallback = OnBannerShown
        };
        Advertisement.Banner.Show(_banner, options);
        //status.text = "Banner Showing";
    }

    private void OnBannerShown(){ }
    private void OnBannerHidden(){ }
    private void OnBannerClicked(){ }

    void LoadReward() => Advertisement.Load(_reward, this);
    public void ShowReward() => Advertisement.Show(_reward, this);

    void LoadInterstitial() => Advertisement.Load(_interstitial, this);
    public void ShowInterstitial() => Advertisement.Show(_interstitial, this);

    public void OnInitializationComplete()
    {
        //Debug.Log("Unity Ads initialization complete.");
    }

    public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    {
        //Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
    }

    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
    }

    public void OnUnityAdsShowStart(string placementId)
    {
    }

    public void OnUnityAdsShowClick(string placementId)
    {
    }

    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        if (placementId.Equals(_reward) && showCompletionState.Equals(UnityAdsShowCompletionState.COMPLETED))
        {
            Debug.Log("Unity Ads Rewarded Ad Completed");
            // Grant a reward.
        }
    }

    public void Exit() => Application.Quit();
}