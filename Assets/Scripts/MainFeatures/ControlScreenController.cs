using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControlScreenController : MonoBehaviour
{
    [SerializeField] Button backButton;

    public void OnEnable()
    {
        backButton.onClick.AddListener(HandleBackButtonClicked);
    }

    public void OnDisable()
    {
        backButton.onClick.RemoveListener(HandleBackButtonClicked);
    }

    public void HandleBackButtonClicked()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
