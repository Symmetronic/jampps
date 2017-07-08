using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTrigger : MonoBehaviour {

    public AudioSource audio;
    public GameObject message;
    public GameObject karsten;
    public GameObject snake_controller;
    public bool finish;
    private bool flawless;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!finish)
        {
            GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>().SetSnakeFlawless(false);
        }
        snake_controller.GetComponent<minigame_snake>().Stop();
        audio.Play();
        ShowMessage();
        if(finish)
        {
            if (!GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>().GetSnakeFlawless())
            {
                GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>().AddScore("snake", 10);
            }
            else
            {
                GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>().AddScore("snake", 1);
            }
            SceneManager.LoadScene("MinigameSnakeFeedback");
        }
       
    }

    private void ShowMessage()
    {
        if (!finish)
        {
            VisibilityController visibilityController = message.GetComponent<VisibilityController>();
            visibilityController.Show(message);
            visibilityController.Show(karsten);
        }
    }



}
