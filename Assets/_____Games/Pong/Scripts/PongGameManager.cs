using UnityEngine;

public class PongGameManager : MonoBehaviour
{
    private int playerScore;
    private int computerScore;
    public PongBall ball;

    public void PlayerScore()
    {
        playerScore++;

        this.ball.ResetPosition();
    }

    public void ComputerScore()
    {
        computerScore++;

        this.ball.ResetPosition();
    }
}
