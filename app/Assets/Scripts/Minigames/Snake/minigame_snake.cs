using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class minigame_snake : MonoBehaviour
{
    Vector2 dir = Vector2.down;
    public GameObject snake;
    public GameObject tail;
   



    void Start()
    {
       
        //InvokeRepeating("Longer", 0.1f, 0.1f);
    }

    void Update()
    {
        Move();
        Longer();
        
      
        if (dir == -Vector2.right)
        {

            if (Input.GetKey(KeyCode.DownArrow))
                dir = -Vector2.up;    // '-up' means 'down'
            else if (Input.GetKey(KeyCode.LeftArrow))
                dir = -Vector2.right; // '-right' means 'left'
            else if (Input.GetKey(KeyCode.UpArrow))
                dir = Vector2.up;
        }

        else if (dir == Vector2.right)
        {
            if (Input.GetKey(KeyCode.RightArrow))
                dir = Vector2.right;
            else if (Input.GetKey(KeyCode.DownArrow))
                dir = -Vector2.up;    // '-up' means 'down'
            else if (Input.GetKey(KeyCode.UpArrow))
                dir = Vector2.up;
        }
        else if (dir == Vector2.up)
        {
            if (Input.GetKey(KeyCode.RightArrow))
                dir = Vector2.right;
            else if (Input.GetKey(KeyCode.LeftArrow))
                dir = -Vector2.right; // '-right' means 'left'
            else if (Input.GetKey(KeyCode.UpArrow))
                dir = Vector2.up;
        }
        else if (dir == -Vector2.up)
        {
            if (Input.GetKey(KeyCode.RightArrow))
                dir = Vector2.right;
            else if (Input.GetKey(KeyCode.DownArrow))
                dir = -Vector2.up;    // '-up' means 'down'
            else if (Input.GetKey(KeyCode.LeftArrow))
                dir = -Vector2.right; // '-right' means 'left'
        }




    }
    void Move()
    {
        
        snake.transform.Translate(dir);
       
    }
    void Longer()
    {
        // Load Prefab into the world
        GameObject g = (GameObject)Instantiate(tail, snake.transform.position, Quaternion.identity);
    }
    public void Stop()
    {
        dir = new Vector2(0, 0);
    }
}