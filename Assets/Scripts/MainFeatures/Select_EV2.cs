using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using TMPro;

public class Select_EV2 : Selecting
{
    private void Start()
    {
        flyBronzeButton.onClick.AddListener(OnFlyBronzeButtonClicked);
        crsiterButton.onClick.AddListener(OnCrsiterButtonClicked);
        flitterMouseButton.onClick.AddListener(OnFlitterMouseButtonClicked);
        //wildwrathButton.onClick.AddListener(OnWildWrathButtonClicked);
        humanStrikeButton.onClick.AddListener(OnHumanStrikeButtonClicked);

        imageToChange = GetComponent<Image>();
    }

    private void OnFlyBronzeButtonClicked()
    {
        choosingCharacters("ea");
    }

    private void OnHumanStrikeButtonClicked()
    {
        choosingCharacters("ed");
    }
        
    private void OnCrsiterButtonClicked()
    {
        choosingCharacters("eb");
    }

    private void OnFlitterMouseButtonClicked()
    {
        choosingCharacters("ec");
    }

}
