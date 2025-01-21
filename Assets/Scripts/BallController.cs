using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;
    
    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

}
