using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTrigger : MonoBehaviour {

    public AudioSource audio;
    public GameObject message;
    public GameObject karsten;
    public GameObject snake_controller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        snake_controller.GetComponent<minigame_snake>().Stop();
        audio.Play();
        ShowMessage();
    }

    private void ShowMessage()
    {
        VisibilityController visibilityController = message.GetComponent<VisibilityController>();
        visibilityController.Show(message);
        visibilityController.Show(karsten);
    }



}
