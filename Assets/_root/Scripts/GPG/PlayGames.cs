using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.SavedGame;
using System;
using TMPro;
using System.IO;
using System.Text;
using static GameManager;

public enum SaveGameOperation
{
    Load, Save
}

public class PlayGames : MonoBehaviour
{
    public static PlayGames playGames { get; private set; }
    public TextMeshProUGUI check, debug;
    string savefile;
    bool isOnline, isAuthed;
    ISavedGameClient savedGameClient;
    private void Awake()
    {
        if (playGames == null)
            playGames = this;
        else
            Destroy(this);
        savefile = "scores";
    }

    public void LoadGPG()
    {
        isOnline = Application.internetReachability == NetworkReachability.NotReachable ? false : true;
        if (isOnline)
        {
            PlayGamesPlatform.Activate();
            PlayGamesPlatform.Instance.Authenticate(GooglePlayGames.BasicApi.SignInInteractivity.CanPromptAlways, ProcessAuthentication);
            savedGameClient = PlayGamesPlatform.Instance.SavedGame;
            isAuthed = true;
        }
    }

    public void SignInInteractivity()
    {

    }

    public void ProcessAuthentication(SignInStatus status)
    {
        //check.text = "entered";
        //check.text = status.ToString();
        if (status == SignInStatus.Success)
        {
            GPGSave(gpgAction);

        }
        else
        {
            check.text = "Failed";

        }
    }

    public void GPGUI()
    {
        if (isOnline)
        {
            if (isAuthed)
            {
                PlayGamesPlatform.Instance.SignOut();
            }
            PlayGamesPlatform.Activate();
            PlayGamesPlatform.Instance.Authenticate(GooglePlayGames.BasicApi.SignInInteractivity.CanPromptAlways, ProcessAuthentication);
            savedGameClient = PlayGamesPlatform.Instance.SavedGame;
        }

    }
    public void OnSavedGameSelected(SelectUIStatus status, ISavedGameMetadata game)
    {
        if (status == SelectUIStatus.SavedGameSelected)
        {
            // handle selected game save
        }
        else
        {
            // handle cancel or error
        }
    }

    public void GPGSave(SaveGameOperation operation)
    {
        if (operation == SaveGameOperation.Load)
        {
            check.text = "load";
            savedGameClient = PlayGamesPlatform.Instance.SavedGame;
            Debug.Log(savedGameClient.ToString());
            savedGameClient.OpenWithAutomaticConflictResolution(savefile, DataSource.ReadCacheOrNetwork,
            ConflictResolutionStrategy.UseLongestPlaytime, OnSavedGameOpenedToLoad);
        }
        if (operation == SaveGameOperation.Save)
        {
            check.text = "save";
            savedGameClient = PlayGamesPlatform.Instance.SavedGame;
            Debug.Log(savedGameClient.ToString());
            savedGameClient.OpenWithAutomaticConflictResolution(savefile, DataSource.ReadCacheOrNetwork,
            ConflictResolutionStrategy.UseLongestPlaytime, OnSavedGameOpened);
        }
    }

    private void OnSavedGameOpened(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            // handle reading or writing of saved game.
            check.text = "OnSavedGameOpened";

            /*string scjson = JsonUtility.ToJson(saver.scoredata);
            string usrjson = JsonUtility.ToJson(saver.usrdata);
            byte[] scdata = Encoding.UTF8.GetBytes(scjson);
            byte[] usrdata = Encoding.UTF8.GetBytes(usrjson);*/
            string savedata = JsonUtility.ToJson(saver);
            byte[] fullsave = Encoding.UTF8.GetBytes(savedata);

            SavedGameMetadataUpdate.Builder builder = new SavedGameMetadataUpdate.Builder();
            SavedGameMetadataUpdate update = builder.Build();
            savedGameClient = PlayGamesPlatform.Instance.SavedGame;
            savedGameClient.CommitUpdate(game, update, fullsave, OnSavedGameWritten);
            check.text = "save commit";
            debug.text = game.ToString();
        }
        else
        {
            // handle error
            check.text = "Save Load Failed";
        }
    }


    void OnSavedGameOpenedToLoad(SavedGameRequestStatus status, ISavedGameMetadata metadata)
    {
        savedGameClient.ReadBinaryData(metadata, OnSavedGameDataRead);
    }
    public void OnSavedGameDataRead(SavedGameRequestStatus status, byte[] savedata)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            check.text = "loading2";
            string data = Encoding.UTF8.GetString(savedata);
            // handle processing the byte array data

            debug.text = data;
            JsonUtility.FromJsonOverwrite(data, saver.usrdata);
            if (data != null)
            {

            }
            check.text = "Loaded Data from Cloud";
        }
        else
        {
            // handle error
            check.text = "nope";
        }
    }


    private void OnSavedGameWritten(SavedGameRequestStatus status, ISavedGameMetadata metaData)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            Debug.Log("Save successful");
        }
        else
        {
            Debug.LogError("Failed to write saved game data");
        }
    }

    private void DeleteSaveData(string filename)
    {
        savedGameClient.OpenWithAutomaticConflictResolution(filename, DataSource.ReadCacheOrNetwork,
                    ConflictResolutionStrategy.UseLongestPlaytime, DeleteSavedGame);
    }

    private void DeleteSavedGame(SavedGameRequestStatus status, ISavedGameMetadata game)
    {
        if (status == SavedGameRequestStatus.Success)
        {
            savedGameClient.Delete(game);
        }
        else
        {

        }
    }
}
