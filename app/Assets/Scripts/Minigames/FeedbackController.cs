using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackController : MonoBehaviour {

    public string nextScene;
    public string chapterCompleteScene = "";
    public int chapter;

    public void GoToNextScene()
    {
        MenuController menuCtrl = GetComponent<MenuController>();
        GameObject score = GameObject.FindGameObjectWithTag("Score");
        ScoreController scoreCtrl = score.GetComponent<ScoreController>();
        if (chapterCompleteScene != "" && score && scoreCtrl.ChapterComplete(chapter))
        {
            menuCtrl.ChangeScene(chapterCompleteScene);
        }
        else
        {
            menuCtrl.ChangeScene(nextScene);
        }
    }
}
