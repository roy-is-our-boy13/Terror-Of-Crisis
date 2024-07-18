using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using TMPro;

public class Select_AV2 : Selecting
{
     private void Start()
    {

        //flyBronzeButton.onClick.AddListener(OnFlyBronzeButtonClicked);
        crsiterButton.onClick.AddListener(OnCrsiterButtonClicked);
        flitterMouseButton.onClick.AddListener(OnFlitterMouseButtonClicked);
        wildwrathButton.onClick.AddListener(OnWildWrathButtonClicked);
        humanStrikeButton.onClick.AddListener(OnHumanStrikeButtonClicked);

        imageToChange = GetComponent<Image>();
    }

    private void OnHumanStrikeButtonClicked()
    {
        choosingCharacters("ad");
    }

    private void OnWildWrathButtonClicked()
    {
        choosingCharacters("ae");
    }

    private void OnCrsiterButtonClicked()
    {
        choosingCharacters("ab");
    }

    private void OnFlitterMouseButtonClicked()
    {
        choosingCharacters("ac");
    }
}
