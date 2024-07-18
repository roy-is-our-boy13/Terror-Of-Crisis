using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class HowManyPlayers : MonoBehaviour
{
    [SerializeField] Button onePlayerButton;
    [SerializeField] Button twoPlayerButton;
    [SerializeField] Button threePlayerButton;
    [SerializeField] Button fourPlayerButton;

    GameObject loadingScreen;
    LoadingScreen loadingScreenComponent;

    
    public void HandleOnePlayerButtonClicked()
    {
       SceneManager.LoadSceneAsync("MainMenu");
    }

    public void HandleTwoPlayerButtonClicked()
    {
       SceneManager.LoadSceneAsync("Select");
    }

    public void HandleThreePlayerButtonClicked()
    {
       SceneManager.LoadSceneAsync("Select2");
    }

    public void HandleFourPlayerButtonClicked()
    {
       SceneManager.LoadSceneAsync("");
    }


    public void OnEnable()
    {
        
        onePlayerButton.onClick.AddListener(HandleOnePlayerButtonClicked);
        twoPlayerButton.onClick.AddListener(HandleTwoPlayerButtonClicked);
        threePlayerButton.onClick.AddListener(HandleThreePlayerButtonClicked);
        fourPlayerButton.onClick.AddListener(HandleFourPlayerButtonClicked);
       

        if (loadingScreen != null)
        {
            loadingScreenComponent = loadingScreen.GetComponent<LoadingScreen>();
        }

        if(loadingScreenComponent != null)
        {
            onePlayerButton.onClick.RemoveListener(HandleOnePlayerButtonClicked);
            twoPlayerButton.onClick.RemoveListener(HandleTwoPlayerButtonClicked);
            threePlayerButton.onClick.RemoveListener(HandleThreePlayerButtonClicked);
            fourPlayerButton.onClick.RemoveListener(HandleFourPlayerButtonClicked);
        
        }
    }


    
}
