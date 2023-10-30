using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System;
using TMPro;
using GooglePlayGames.BasicApi.SavedGame;

public class PlayGames : MonoBehaviour
{
    public TextMeshProUGUI check;

    void Start()
    {
        //PlayGamesPlatform.Activate();
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);

    }

    private void ProcessAuthentication(SignInStatus status)
    {
        if (status == SignInStatus.Success) { check.text = "Success";
            OpenSavedGame("scglobal.json");
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
        ISavedGameClient savedGameClient = PlayGamesPlatform.Instance.SavedGame;
        savedGameClient.OpenWithAutomaticConflictResolution(filename, DataSource.ReadCacheOrNetwork,
            ConflictResolutionStrategy.UseLongestPlaytime, OnSavedGameOpened);
    }

    private void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            // handle reading or writing of saved game.
            check.text = "OpenSavedGame";
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
