using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1000f;
    public Rigidbody rb;

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(0, 0, speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            rb.AddForce((-1 * speed) * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(0, 0, (-1 * speed) * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(speed * Time.deltaTime, 0, 0);
    }
}
