using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScript_Final : TestScript
{
    [SerializeField] string fightScence;


    public void Start()
    {
        OpenConfirmationWindow("Are You Sure?");
    }

    public void OpenConfirmationWindow(string message)
    {
        myConfirmationWindow.gameObject.SetActive(true);
        myConfirmationWindow.yesButton.onClick.AddListener(YesClicked);
        myConfirmationWindow.noButton.onClick.AddListener(NoClicked);
        myConfirmationWindow.messageText.text = message;
        //select.scene = nextScence;
        //SceneManager.LoadSceneAsync(nextScence);
    }

    public void YesClicked()
    {
        myConfirmationWindow.gameObject.SetActive(false);
        select.scene = nextScence;
        nextScence = fightScence;
        //SceneManager.LoadSceneAsync(nextScence);
        select.choosingCharacters(nextScence);

        Debug.Log("Yes Clicked");
    }
}
