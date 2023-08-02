using UnityEngine;

public class PongBall : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 200f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
    }

    public void ResetPosition()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;

        AddStartingForce();
    }

    private void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        rb.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        rb.AddForce(force);
    }    
}
