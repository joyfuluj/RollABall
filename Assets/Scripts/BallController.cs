using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

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

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        // Debug.Log("Resultant Vector: " + inputVector);
        // Debug.Log("Resultant 3D Vector: " + inputXZPlane);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);

    }
}
