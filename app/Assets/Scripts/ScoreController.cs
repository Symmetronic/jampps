using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {
    private GameScore score = new GameScore();
    private bool snakeFlawless = true;
    private bool ateDinner = false;
    private bool enteredHouse = false;
    private bool bike = false;
    /* Minigame score getters */
    public float GetLightMinigame1Score()
    {
        return score.light1;
    }

    public float GetLightMinigame2Score()
    {
        return score.light2;
    }

    public float GetSnakeMinigameScore()
    {
        return score.snake;
    }

    public float GetWaterMinigame1Score()
    {
        return score.water1;
    }

    public float GetWaterMinigame2Score()
    {
        return score.water2;
    }

    public bool GetBike()
    {
        return this.bike;
    }

    public string GetBadge(string minigame)
    {
        float minigameScore = score.GetScore(minigame);
        if (minigameScore >= 0.75)
            return "gold";
        return "silver";
    }

    /* Use this function to add a score to a minigame */
    public void AddScore(string minigame, int score)
    {
        this.score.AddScore(minigame, score);
    }

    /* Check if chapter is complete */
    public bool ChapterComplete(int chapter)
    {
        switch (chapter)
        {
            case 1:
                if (SolvedLightMinigame1() && SolvedWaterMinigame1())
                    return true;
                break;
            case 2:
                if (SolvedWaterMinigame2())
                    return true;
                break;
            case 3:
                if (SolvedLightMinigame2() && SolvedSnakeMinigame())
                    return true;
                break;
        }
        return false;
    }

    /* Check if minigames are solved */
    public bool SolvedLightMinigame1()
    {
        return GetLightMinigame1Score() > 0;
    }

    public bool SolvedLightMinigame2()
    {
        return GetLightMinigame2Score() > 0;
    }

    public bool SolvedSnakeMinigame()
    {
        return GetSnakeMinigameScore() > 0;
    }

    public bool SolvedWaterMinigame1()
    {
        return GetWaterMinigame1Score() > 0;
    }

    public bool SolvedWaterMinigame2()
    {
        return GetWaterMinigame2Score() > 0;
    }

    //Functions for SnakeScore
    public void SetSnakeFlawless(bool value)
    {
        snakeFlawless = value;
    }
    public bool GetSnakeFlawless()
    {
        return snakeFlawless;
    }

    public void SetAteDinner(bool value)
    {
        ateDinner = value;
    }
    public bool GetAteDinner()
    {
        return ateDinner;
    }

    public void SetEnteredHouse(bool value)
    {
        enteredHouse = value;
    }
    public bool GetEnteredHouse()
    {
        return enteredHouse;
    }

    public void ResetScore()
    {
        score.ResetScore();
        this.bike = false;
        this.snakeFlawless = true;
        this.ateDinner = false;
        this.enteredHouse = false;
    }

    public void SetBike(bool bike)
    {
        this.bike = bike;

    }

    
 }

class GameScore
{
    public float light1 = 0;
    private int light1Opt = 2;
    public float light2 = 0;
    private int light2Opt = 3;
    public float snake = 0;
    private int snakeOpt = 1;
    public float water1 = 0;
    private int water1Opt = 11;
    public float water2 = 0;
    public int water2Opt = 17;
   

    public void AddScore(string minigame, int score)
    {
        switch (minigame)
        {
            case "light1":
                light1 = (float)light1Opt / (float)score;
                break;
            case "light2":
                light2 = (float)light2Opt / (float)score;
                break;
            case "snake":
                snake = (float)snakeOpt / (float)score;
                break;
            case "water1":
                water1 = (float)water1Opt / (float)score;
                break;
            case "water2":
                water2 = (float)water2Opt / (float)score;
                break;
        }
    }

    public float GetScore(string minigame)
    {
        switch (minigame)
        {
            case "light1":
                return light1;
            case "light2":
                return light2;
            case "snake":
                return snake;
            case "water1":
                return water1;
            case "water2":
                return water2;
            default:
                return 0f;
        }
    }

    public void ResetScore()
    {
        light1 = 0f;
        light2 = 0f;
        snake = 0f;
        water1 = 0f;
        water2 = 0f;
    }

}
