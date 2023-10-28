using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public static CameraManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            MoveCamera(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            MoveCamera(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveCamera(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveCamera(Vector2.right);
        }
    }


    public void MoveCamera(Vector2 direction)
    {
        var tempTransform = transform.position;

        if (direction == Vector2.up)
        {
            tempTransform.y += 12;
        }
        else if (direction == Vector2.down)
        {
            tempTransform.y -= 12;
        }
        else if (direction == Vector2.left)
        {
            tempTransform.x -= 20;
        }
        else if (direction == Vector2.right)
        {
            tempTransform.x += 20;
        }

        transform.position = tempTransform;
    }
}
