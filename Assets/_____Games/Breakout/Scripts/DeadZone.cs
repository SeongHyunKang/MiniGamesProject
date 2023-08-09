using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            FindObjectOfType<BreakoutGameManager>().Dead();
        }
    }
}
