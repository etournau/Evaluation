using UnityEngine;
using UnityEngine.InputSystem;

public class SnakeController : MonoBehaviour
{
    private Vector2 _direction = Vector2.right;

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            _direction = Vector2.right;
        else if (Input.GetKey(KeyCode.DownArrow))
            _direction = -Vector2.up;    
        else if (Input.GetKey(KeyCode.LeftArrow))
            _direction = -Vector2.right; 
        else if (Input.GetKey(KeyCode.UpArrow))
            _direction = Vector2.up;
    }
}
