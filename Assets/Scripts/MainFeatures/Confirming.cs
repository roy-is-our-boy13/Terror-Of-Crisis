using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using TMPro;

public class Confirming : MonoBehaviour
{
    [SerializeField] public Button yesButton;
    [SerializeField] public Button noButton;

    public TextMeshProUGUI messageText;
}
