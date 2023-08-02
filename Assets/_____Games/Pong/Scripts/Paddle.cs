using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D rb;
    public float speed = 10f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
