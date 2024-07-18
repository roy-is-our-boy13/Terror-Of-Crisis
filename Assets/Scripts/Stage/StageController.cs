using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StageController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public event Action<int> HoveredOverStage;
    public event Action HideStageImage;
    [SerializeField] int index;
    LoadingScreen loadingScreen;

    public void Awake()
    {
        loadingScreen = GameObject.Find("LoadingCanvas").GetComponent<LoadingScreen>();

        if(loadingScreen != null)
        {
            loadingScreen.HideSpinner();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(index == 0)
        {
            SceneManager.LoadSceneAsync("Stage1");
        }
        else if(index == 1)
        {
            SceneManager.LoadSceneAsync("Stage2");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        HoveredOverStage?.Invoke(index);
    }

     public void OnPointerExit(PointerEventData eventData)
    {
        HideStageImage?.Invoke();
    }
}

