using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;
    public float jumpHeight = 4f;
    public bool onGround = false;
    
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Floor")
        {
            onGround = true;
        }
    }
    
    public void MoveBall(Vector3 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);

        if(input.z > 0 && onGround)
        {
            sphereRigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            onGround = false;
        }

        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

}
