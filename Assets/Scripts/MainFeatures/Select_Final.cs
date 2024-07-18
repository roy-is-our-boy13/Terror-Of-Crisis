using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using TMPro;

public class Select_Final : Selecting
{
    [SerializeField] string forFlyBronze;
    [SerializeField] string forCrister;
    [SerializeField] string forFlitterMouse;
    [SerializeField] string forHumanStrike;
    [SerializeField] string forWildWrath;

    private void Start()
    {
        flyBronzeButton.onClick.AddListener(OnFlyBronzeButtonClicked);
        crsiterButton.onClick.AddListener(OnCrsiterButtonClicked);
        flitterMouseButton.onClick.AddListener(OnFlitterMouseButtonClicked);
        wildwrathButton.onClick.AddListener(OnWildWrathButtonClicked);
        humanStrikeButton.onClick.AddListener(OnHumanStrikeButtonClicked);

        imageToChange = GetComponent<Image>();
    }

    private void OnFlyBronzeButtonClicked()
    {
        choosingCharacters(forFlyBronze);
    }

    private void OnHumanStrikeButtonClicked()
    {
        choosingCharacters(forHumanStrike);
    }
        
    private void OnCrsiterButtonClicked()
    {
        choosingCharacters(forCrister);
    }

    private void OnFlitterMouseButtonClicked()
    {
        choosingCharacters(forFlitterMouse);
    }

    private void OnWildWrathButtonClicked()
    {
        choosingCharacters(forWildWrath);
    }
}
