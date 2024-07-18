using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO; 

public class FinishPoint : MonoBehaviour
{
    [SerializeField] bool goNextLevel;
    [SerializeField] string levelName;
    [SerializeField] string Current_Player;

    string filePath, data;
    int currentLevelIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(Current_Player))
        {
            if(goNextLevel)
            {
                //SaveGame();
                SceneController.instance.NextLevel();
            }
            else
            {
                //SaveGame();
                SceneController.instance.LoadScene(levelName);
            }
        }
    }

}
