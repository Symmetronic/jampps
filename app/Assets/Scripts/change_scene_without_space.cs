using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_scene_without_space: MonoBehaviour
{
    public int scene;

   
    void OnTriggerEnter2D(Collider2D player)
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene(scene);

    }

}
