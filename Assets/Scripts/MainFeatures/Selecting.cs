using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using TMPro;

public class Selecting : MonoBehaviour
{
    [SerializeField] public Button flyBronzeButton;
    [SerializeField] public Button crsiterButton;
    [SerializeField] public Button flitterMouseButton;
    [SerializeField] public Button wildwrathButton;
    [SerializeField] public Button humanStrikeButton;

    [SerializeField] public Image imageToChange;
    [SerializeField] public Sprite newImage;

    [SerializeField] public Button yesButton;
    [SerializeField] public Button noButton;

    public TextMeshProUGUI messageText;

    //public TextMeshProUGUI mssageText;

    public bool flyBronzePressed = false;
    public bool crsiterPressed = false;
    public bool flitterMousePressed = false;
    public bool wildwrathPressed = false;
    public bool humanStrikePressed = false;
    public string scene;

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
        choosingCharacters("d");
        /*humanStrikePressed = true;
        CheckButtons();*/
    }

    private void OnWildWrathButtonClicked()
    {
        choosingCharacters("e");
      
       /* wildwrathPressed = true;
        CheckButtons();*/
    }

    private void OnFlyBronzeButtonClicked()
    {
        choosingCharacters("a");
        /*flyBronzePressed = true;
        CheckButtons();*/
    }

    private void OnCrsiterButtonClicked()
    {
        choosingCharacters("b");
        /*crsiterPressed = true;
        CheckButtons();*/
    }

    private void OnFlitterMouseButtonClicked()
    {
        choosingCharacters("c");
        /*flitterMousePressed = true;
        CheckButtons();*/
    }

    
    private void CheckButtons()
    {
        if(flyBronzePressed)
        {

            //SceneManager.LoadSceneAsync("Selecta");

            //imageToChange.sprite = newImage;
/*
            if(crsiterPressed)
            {
                 //OpenConfirmationWindow("Are you Sure.");
                choosingCharacters("fight2");
            }
            else if(flitterMousePressed)
            {
                choosingCharacters("fight3");
            }
            else if(wildwrathPressed)
            {
                choosingCharacters("fight4");
            }
            else if(humanStrikePressed)
            {
                choosingCharacters("fight5");
            }*/
        }
        else if(crsiterPressed)
        {
            /*
            if(flyBronzePressed)
            {
                choosingCharacters("fight6");
            }
            else if(flitterMousePressed)
            {
                choosingCharacters("Level2");
            }
            else if(wildwrathPressed)
            {
                choosingCharacters("Level2");
            }
            else if(humanStrikePressed)
            {
                choosingCharacters("Level2");
            }*/
        }
        else if(flitterMousePressed)
        {
            /* if(flyBronzePressed)
            {
                choosingCharacters("Level2");
            }
            else if(crsiterPressed)
            {
                choosingCharacters("Level2");
            }
            else if(wildwrathPressed)
            {
                choosingCharacters("Level2");
            }
            else if(humanStrikePressed)
            {
                choosingCharacters("Level2");
            }*/
        }
        else if(wildwrathPressed)
        {
            /* if(flyBronzePressed)
            {
                choosingCharacters("Level2");
            }
            else if(crsiterPressed)
            {
                choosingCharacters("Level2");
            }
            else if(flitterMousePressed)
            {
                choosingCharacters("Level2");
            }
            else if(humanStrikePressed)
            {
                choosingCharacters("Level2");
            }*/
        }
        else if(humanStrikePressed)
        {
            /* if(flyBronzePressed)
            {
                choosingCharacters("Level2");
            }
            else if(crsiterPressed)
            {
                choosingCharacters("Level2");
            }
            else if(flitterMousePressed)
            {
                choosingCharacters("Level2");
            }
            else if(wildwrathPressed)
            {
                choosingCharacters("Level2");
            }*/
        }
        
        /*    if (flyBronzePressed && crsiterPressed)
            {
                choosingCharacters("Level2");
            }
            else if(flyBronzePressed && flitterMousePressed)
            {
                choosingCharacters("Level2");
        }
        else if(flyBronzePressed && wildwrathPressed)
        {
            choosingCharacters("Level2");
        }
        else if(flyBronzePressed && humanStrikePressed)
        {
            choosingCharacters("Level2");
        }


        else if(humanStrikePressed && flitterMousePressed)
        {
            choosingCharacters("Level2");
        }
        else if(humanStrikePressed && crsiterPressed)
        {
            choosingCharacters("Level2");
        }
        else if(humanStrikeButton && wildwrathButton)
        {
            choosingCharacters("Level2");
        }
        else if(flitterMousePressed && crsiterPressed)
        {
            choosingCharacters("Level2");
        }
        else if(flitterMousePressed && wildwrathPressed)
        {
            choosingCharacters("Level2");
        }
        else if(wildwrathPressed && crsiterButton)
        {
            choosingCharacters("Level2");
        }*/
    }

    public void choosingCharacters(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

/*

     private void OpenConfirmationWindow(string message)
    {
        gameObject.SetActive(true);
        yesButton.onClick.AddListener(YesClicked);
        noButton.onClick.AddListener(NoClicked);
        messageText.text = message;
        //select.scene = nextScence;
        //SceneManager.LoadSceneAsync(nextScence);

    }

    public void YesClicked()
    {
        gameObject.SetActive(false);
        scene = "fight2";
        //SceneManager.LoadSceneAsync(nextScence);
        choosingCharacters(scene);

        Debug.Log("Yes Clicked");
    }

    public void NoClicked()
    {
        gameObject.SetActive(false);

        flyBronzePressed = false;
        crsiterPressed = false;
        flitterMousePressed = false;
        wildwrathPressed = false;
        humanStrikePressed = false;
        Debug.Log("No Clicked");
    }

   */
}
