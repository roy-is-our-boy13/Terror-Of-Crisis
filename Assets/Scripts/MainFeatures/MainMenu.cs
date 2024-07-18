using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button newGameButton;
    [SerializeField] Button loadGameButton;
    [SerializeField] Button startGameButton;
    [SerializeField] Button settingsButton;
    [SerializeField] Button controlsButton;
    [SerializeField] Button quitButton;

    string filePath;
    string data;
    int savedLevelIndex;
    GameObject loadingScreen;
    LoadingScreen loadingScreenComponent;

    public void HandleNewGameButtonClicked()
    {
       SceneManager.LoadSceneAsync("Level2");
    }

    public void HandleLoadGameButtonClicked()
    {
       filePath = Application.persistentDataPath + "/savegame.txt";

        if (File.Exists(filePath))
        {
            data = File.ReadAllText(filePath);

            if (int.TryParse(data, out savedLevelIndex))
            {
                SceneManager.LoadScene(savedLevelIndex);
            }
            else
            {
                Debug.LogWarning("Failed to parse saved level index from file.");
            }
        }
        else
        {
            Debug.LogWarning("No save file found.");
        } 
    }

    public void HandleStartGameButtonClicked()
    {
        SceneManager.LoadSceneAsync("Select");
    }

    public void HandleControlsButtonsClicked()
    {
        SceneManager.LoadSceneAsync("Settings");
    }

    public void HandleSettingsClicked()
    {
        SceneManager.LoadSceneAsync("Controls");
    }

    public void HandleExitClicked()
    {
        Application.Quit();

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void OnEnable()
    {
        
        newGameButton.onClick.AddListener(HandleNewGameButtonClicked);
        loadGameButton.onClick.AddListener(HandleLoadGameButtonClicked);
        startGameButton.onClick.AddListener(HandleStartGameButtonClicked);
        settingsButton.onClick.AddListener(HandleControlsButtonsClicked);
        controlsButton.onClick.AddListener(HandleSettingsClicked);
        quitButton.onClick.AddListener(HandleExitClicked);

        if (loadingScreen != null)
        {
            loadingScreenComponent = loadingScreen.GetComponent<LoadingScreen>();
        }

        if(loadingScreenComponent != null)
        {
            newGameButton.onClick.RemoveListener(HandleNewGameButtonClicked);
            loadGameButton.onClick.RemoveListener(HandleLoadGameButtonClicked);
            startGameButton.onClick.RemoveListener(HandleStartGameButtonClicked);
            settingsButton.onClick.RemoveListener(HandleControlsButtonsClicked);
            controlsButton.onClick.RemoveListener(HandleSettingsClicked);
            quitButton.onClick.RemoveListener(HandleExitClicked);
        }
    }
}
