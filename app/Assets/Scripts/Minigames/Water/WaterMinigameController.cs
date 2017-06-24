using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMinigameController : MonoBehaviour {

    public string nextScene;
    public string minigameName;
    public int fieldSize;
    public float gridUnit = 67;
    public GameObject[] obstacles;
    private int score = 0;
    
    public bool IsEmpty(Vector2 position)
    {
        if ((position.x < 1 && position.y != 3) || position.x < -1 || position.y < 1 || (position.x > fieldSize && position.y != 3) || position.x > (fieldSize + 2) || position.y > 5)
            return false;
        else
        {
            foreach(GameObject obstacle in obstacles)
            {
                ObstacleController obstCtrl = obstacle.GetComponent<ObstacleController>();
                for (int i = 0; i < obstCtrl.size; i++) {
                    Vector2 currPos = new Vector2();
                    if (obstCtrl.moveHorizontal)
                        currPos.Set(obstCtrl.position.x + i, obstCtrl.position.y);
                    else
                        currPos.Set(obstCtrl.position.x, obstCtrl.position.y + i);
                    if (currPos == position)
                        return false;
                }
            }
            if (position.x == -1 && position.y == 3)
                EndGame();
            return true;
        }
    }

    private void EndGame()
    {
        GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreController>().AddScore(minigameName, score);
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextScene);
    }

    public void RaiseScore()
    {
        score++;
    }
}
