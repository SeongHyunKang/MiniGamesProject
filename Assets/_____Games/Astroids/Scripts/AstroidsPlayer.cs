using UnityEngine;

public class AstroidsPlayer : MonoBehaviour
{
    public float thrustSpeed;
    public float turnSpeed;

    private Rigidbody2D rb;
    private bool isThrusting;
    private float turnDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        isThrusting = Input.GetKey(KeyCode.W);

        if (Input.GetKey(KeyCode.A))
        {
            turnDirection = 1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            turnDirection = -1f;
        }
        else
        {
            turnDirection = 0f;
        }
    }

    private void FixedUpdate()
    {
        if (isThrusting)
        {
            rb.AddForce(this.transform.up * thrustSpeed);
        }

        if (turnDirection != 0)
        {
            rb.AddTorque(turnDirection * this.turnSpeed);
        }
    }
}
