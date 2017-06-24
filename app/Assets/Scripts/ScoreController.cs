using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {
    private GameScore score = new GameScore();

    public void AddScore(string minigame, int score)
    {
        this.score.AddScore(minigame, score);
    }

    public bool ChapterComplete(int chapter)
    {
        switch(chapter)
        {
            case 1:
                if (score.light1 > 0 && score.water1 > 0)
                    return true;
                break;
        }
        return false;
    }
}

class GameScore
{
    public float light1 = 0;
    private int light1Opt = 3;
    public float water1 = 0;
    private int water1Opt = 17;

    public void AddScore(string minigame, int score)
    {
        switch (minigame)
        {
            case "light1":
                light1 = (float)light1Opt / (float)score;
                break;
            case "water1":
                water1 = (float)water1Opt / (float)score;
                break;
        }
    }
}

