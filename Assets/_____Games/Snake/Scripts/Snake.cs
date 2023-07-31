using UnityEngine;

public class Snake : MonoBehaviour
{
    private Vector2 direction = Vector2.right;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector2.down;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            direction = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            direction = Vector2.right;
        }
    }

    private void FixedUpdate()
    {
        ChangeFixedTimestep(0.04f);

        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x + direction.x),
            Mathf.Round(this.transform.position.y + direction.y),
            0f);
    }

    private void ChangeFixedTimestep(float newTimestep)
    {
        Time.fixedDeltaTime = newTimestep;
    }
}
