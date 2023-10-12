using System;
using TMPro;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdLoader : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener
{
    [SerializeField] string _androidAdUnitId, _iOsAdUnitId = "Interstitial_iOS";
    private string _adUnitId;

    [SerializeField] BannerPosition _position = BannerPosition.BOTTOM_CENTER;

    public TextMeshProUGUI textbox;

    void Awake()
    {
        _adUnitId = (Application.platform != RuntimePlatform.IPhonePlayer) ? _androidAdUnitId : _iOsAdUnitId;

        Advertisement.Banner.SetPosition(_position);
    }

    private void Start()
    {
        
        if (_adUnitId == "Banner_Android" || _adUnitId == "Banner_Android")
        {
            LoadBanner();
            ShowBannerAd();
        }
        else
        {
            LoadAd();
        }
    }

    public void LoadAd()
    {
        //Debug.Log("Loading Ad: " + _adUnitId);
        Advertisement.Load(_adUnitId, this);
        textbox.text = "loaded";
    }

    public void ShowAd()
    {
        //Debug.Log("Showing Ad: " + _adUnitId);
        Advertisement.Show(_adUnitId, this);
        textbox.text += "\n shown";
    }

    public void LoadBanner()
    {
        BannerLoadOptions options = new BannerLoadOptions
        {
            loadCallback = OnBannerLoaded,
            errorCallback = OnBannerError
        };
        Advertisement.Banner.Load(_adUnitId, options);
    }

    void OnBannerLoaded()
    {
        print("banner loaded");
    }

    private void OnBannerError(string message)
    {
        print($"Banner error: {message}");
    }

    void ShowBannerAd()
    {
        BannerOptions options = new BannerOptions
        {
            clickCallback = OnBannerClicked,
            hideCallback = OnBannerHidden,
            showCallback = OnBannerShown
        };
        Advertisement.Banner.Show(_adUnitId, options);
    }

    private void OnBannerShown()
    {

    }

    private void OnBannerHidden()
    {

    }

    private void OnBannerClicked()
    {

    }

    public void OnUnityAdsAdLoaded(string _adUnitId) { }

    public void OnUnityAdsFailedToLoad(string _adUnitId, UnityAdsLoadError error, string message) { }

    public void OnUnityAdsShowClick(string _adUnitId) { }

    public void OnUnityAdsShowComplete(string _adUnitId, UnityAdsShowCompletionState showCompletionState)
    {

    }

    public void OnUnityAdsShowFailure(string _adUnitId, UnityAdsShowError error, string message) { }

    public void OnUnityAdsShowStart(string _adUnitId) { }

}
