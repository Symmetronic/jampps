using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour
{
    public string scene;

    void OnTriggerEnter2D(Collider2D player)
    {

        if (GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>().SolvedSnakeMinigame())
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
        }
    }
}
