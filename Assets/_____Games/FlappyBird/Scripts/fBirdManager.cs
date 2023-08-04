using UnityEngine;

public class fBirdManager : MonoBehaviour
{
    private int score;

    public void GameOver()
    {
        Debug.Log("GameOver");
    }

    public void IncreaseScore()
    {
        score++;
    }
}
