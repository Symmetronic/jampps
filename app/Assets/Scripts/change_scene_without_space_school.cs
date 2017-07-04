using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_scene_without_space_school: MonoBehaviour
{
    public string scene;
    public ScoreController scoreController;
   
    void OnTriggerEnter2D(Collider2D player)
    {
        scoreController = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>();

        if(!scoreController.SolvedWaterMinigame2())        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);

    }

}
