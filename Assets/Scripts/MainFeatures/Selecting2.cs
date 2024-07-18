using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class Selecting2 : Selecting
{
    private void Start()
    {
        flyBronzeButton.onClick.AddListener(OnFlyBronzeButtonClicked);
        crsiterButton.onClick.AddListener(OnCrsiterButtonClicked);
        flitterMouseButton.onClick.AddListener(OnFlitterMouseButtonClicked);
        wildwrathButton.onClick.AddListener(OnWildWrathButtonClicked);
        humanStrikeButton.onClick.AddListener(OnHumanStrikeButtonClicked);

        imageToChange = GetComponent<Image>();
    }
    
    private void OnHumanStrikeButtonClicked()
    {
        choosingCharacters("dV2");
    }

    private void OnWildWrathButtonClicked()
    {
        choosingCharacters("eV2");
    }

    private void OnFlyBronzeButtonClicked()
    {
        choosingCharacters("aV2");
    }

    private void OnCrsiterButtonClicked()
    {
        choosingCharacters("bV2");
    }

    private void OnFlitterMouseButtonClicked()
    {
        choosingCharacters("cV2");
    }
}
