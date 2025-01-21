using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if(Input.GetKey(KeyCode.W)){
            // Debug.Log(Vector2.up);
            inputVector += Vector2.up;
        }

        if(Input.GetKey(KeyCode.S)){
            // Debug.Log(Vector2.down);
            inputVector += Vector2.down;
        }

        if(Input.GetKey(KeyCode.D)){
            // Debug.Log(Vector2.right);
            inputVector += Vector2.right;
        }

        if(Input.GetKey(KeyCode.A)){
            // Debug.Log(Vector2.left);
            inputVector += Vector2.left;
        }

        OnMove?.Invoke(inputVector);
    }
}
