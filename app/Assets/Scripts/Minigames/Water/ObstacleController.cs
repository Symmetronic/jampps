using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

    public bool moveHorizontal = true;
    public Vector2 position;
    public int size;
    private WaterMinigameController gameController;

    public void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<WaterMinigameController>();
    }
    
    public void Move()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 objPos = transform.position;
        Vector3 transformVector = new Vector3(0, 0);
        
        if (moveHorizontal)
        {
            if (mousePos.x < objPos.x)
            {
                if (gameController.IsEmpty(new Vector2(position.x - 1, position.y)))
                {
                    transformVector.Set(-1 * gameController.gridUnit, 0, 0);
                    position = new Vector2(position.x - 1, position.y);
                }
            }
            else
            {
                if (gameController.IsEmpty(new Vector2(position.x + size, position.y)))
                {
                    transformVector.Set(gameController.gridUnit, 0, 0);
                    position = new Vector2(position.x + 1, position.y);
                }
            }
        }
        else
        {
            if (mousePos.y < objPos.y)
            {
                if (gameController.IsEmpty(new Vector2(position.x, position.y + size)))
                {
                    transformVector.Set(gameController.gridUnit, 0, 0);
                    position = new Vector2(position.x, position.y + 1);
                }
            }
            else
            {
                if (gameController.IsEmpty(new Vector2(position.x, position.y - 1)))
                {
                    transformVector.Set(-1 * gameController.gridUnit, 0, 0);
                    position = new Vector2(position.x, position.y - 1);
                }
            }
        }
        if (transformVector != new Vector3(0, 0))
        {
            transform.Translate(transformVector);
            gameController.RaiseScore();
        }
    }

}
