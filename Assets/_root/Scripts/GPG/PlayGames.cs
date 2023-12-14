using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using System;
using TMPro;
using System.IO;

public class PlayGames : MonoBehaviour
{
    public static PlayGames playGames { get; private set; }
    public TextMeshProUGUI check;
    string savepath;
    bool isOnline;
    private void Awake()
    {
        if (playGames == null)
            playGames = this;
        else
            Destroy(this);

        savepath = Path.Combine(Application.persistentDataPath, "scglobal.json");
    }

    void Start()
    {
        isOnline = Application.internetReachability == NetworkReachability.NotReachable ? false : true;
        PlayGamesPlatform.Activate();
        if (isOnline)
            PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
        //check.text = "Start";
    }

    private void ProcessAuthentication(SignInStatus status)
    {
        check.text = "entered";
        check.text = status.ToString();
        if (status == SignInStatus.Success)
        {
            check.text = "Success";
            OpenSavedGame(savepath);
        }
        else
            check.text = "Failed";
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OpenSavedGame(string filename)
    {
        check.text = "OpenSavedGame";
        ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
        savedGameClient.OpenWithAutomaticConflictResolution(filename, DataSource.ReadCacheOrNetwork,
            ConflictResolutionStrategy.UseLongestPlaytime, OnSavedGameOpened);
    }

    private void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            // handle reading or writing of saved game.
            check.text = "OnSavedGameOpened";
            GameManager.saver = (Saver)game;
            check.text = "Save Loaded";
        }
        else
        {
            // handle error
            check.text = "Save Load Failed";
        }
    }

    void LoadGameData(ISavedGameMetadata game)
    {
        ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
        savedGameClient.ReadBinaryData(game, OnSavedGameDataRead);
    }

    public void OnSavedGameDataRead(SavedGameRequestStatus status, byte[] data)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            // handle processing the byte array data
        }
        else
        {
            // handle error
        }
    }
}
