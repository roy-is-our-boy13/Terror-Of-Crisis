using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSelection : MonoBehaviour
{
    [SerializeField] Texture2D cursorImage;
    [SerializeField] List<GameObject> stageImage;
    [SerializeField] List<GameObject> stageTexts;
    [SerializeField] List<StageController> stageControllers;
    [SerializeField] GameObject go1;
    [SerializeField] GameObject go2;

    public void Awake()
    {
        Cursor.SetCursor(cursorImage, Vector2.zero, CursorMode.Auto);
    }

    public void OnEnable()
    {
        foreach(StageController stageController in stageControllers)
        {
            stageController.HoveredOverStage += ShowStageStuff;
            stageController.HideStageImage += HideLevelStuff;
        }
    }

    public void OnDisable()
    {
        foreach(StageController stageController in stageControllers)
        {
            stageController.HoveredOverStage -= ShowStageStuff;
            stageController.HideStageImage -= HideLevelStuff;
        }
    }

    public void ShowStageStuff(int index)
    {
        foreach(GameObject go in stageImage)
        {
            if(index == stageImage.IndexOf(go))
            {
                go.SetActive(true);
            }
            else
            {
                go.SetActive(false);
            }
        }

        foreach(GameObject text in stageTexts)
        {
            if(index == stageTexts.IndexOf(text))
            {
                text.SetActive(true);
            }
            else
            {
                text.SetActive(false);
            }
        }

        go1.SetActive(true);
        go2.SetActive(true);
    }

    public void HideLevelStuff()
    {
        foreach(GameObject go in stageImage)
        {
            go.SetActive(false);
        }

        foreach(GameObject text in stageTexts)
        {
            text.SetActive(false);  
        }

        go1.SetActive(false);
        go2.SetActive(false);
    }
}
