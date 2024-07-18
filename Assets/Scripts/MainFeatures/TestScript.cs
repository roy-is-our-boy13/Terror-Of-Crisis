using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestScript : MonoBehaviour
{
    [SerializeField] public Confirming myConfirmationWindow;
    [SerializeField] public Selecting select;
    //public TestScript_1 test1;
    //[SerializeField] private Selecting s;
    public string nextScence;
 

    /*
    public void Start()
    {
        
           OpenConfirmationWindow("Are You Sure?");
            
      
    }

    public void OpenConfirmationWindow(string message)
    {
        //myConfirmationWindow.gameObject.SetActive(true);
        //myConfirmationWindow.yesButton.onClick.AddListener(YesClicked);
        myConfirmationWindow.noButton.onClick.AddListener(NoClicked);
       // myConfirmationWindow.messageText.text = message;
        //select.scene = nextScence;
        //SceneManager.LoadSceneAsync(nextScence);

    }*/

    /*
    public void YesClicked()
    {
        myConfirmationWindow.gameObject.SetActive(false);
        select.scene = nextScence;
        nextScence = "fight2";
        //SceneManager.LoadSceneAsync(nextScence);
        select.choosingCharacters(nextScence);

        Debug.Log("Yes Clicked");
    }*/

    public void NoClicked()
    {
        myConfirmationWindow.gameObject.SetActive(false);

        select.flyBronzePressed = false;
        select.crsiterPressed = false;
        select.flitterMousePressed = false;
        select.wildwrathPressed = false;
        select.humanStrikePressed = false;


        select.scene = nextScence;
        nextScence = "Select";
        //SceneManager.LoadSceneAsync(nextScence);
        select.choosingCharacters(nextScence);

        Debug.Log("No Clicked");
    }
}
