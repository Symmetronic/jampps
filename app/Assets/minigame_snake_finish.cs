using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minigame_snake_finish : MonoBehaviour {

    public GameObject snake_controller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        snake_controller.GetComponent<minigame_snake>().Stop();
    }
}
