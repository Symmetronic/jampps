using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneTable : MonoBehaviour
{
    public string scene;
    // Use this for initialization
    public void OnTriggerEnter2D(Collider2D collision)
    {
            if (!GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>().GetAteDinner())
            {
            UnityEngine.SceneManagement.SceneManager.LoadScene(scene);
            }
        GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>().SetAteDinner(true);

    }

}
