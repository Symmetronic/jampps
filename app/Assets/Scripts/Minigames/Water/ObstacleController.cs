using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour {

    public bool moveHorizontal = true;
    public float gridUnit = 67;
    
    public void Move()
    {
        Vector2 mousePos = Input.mousePosition;
        Vector2 objPos = transform.position;
        Vector3 transformVector = new Vector3();
        
        if (moveHorizontal)
        {
            if (mousePos.x < objPos.x)
                transformVector.Set(-1 * gridUnit, 0, 0);
            else
                transformVector.Set(gridUnit, 0, 0);
        }
        else
        {
            if (mousePos.y < objPos.y)
                transformVector.Set(gridUnit, 0, 0);
            else
                transformVector.Set(-1 * gridUnit, 0, 0);
        }

        transform.Translate(transformVector);
    }

}
