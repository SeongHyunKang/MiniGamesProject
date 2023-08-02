using TMPro;
using UnityEngine;

public class PongGameManager : MonoBehaviour
{
    private int playerScore;
    private int computerScore;
    public PongBall ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;

    public void PlayerScore()
    {
        playerScore++;

        this.playerScoreText.text = playerScore.ToString();
        ResetField();
    }

    public void ComputerScore()
    {
        computerScore++;

        this.computerScoreText.text = computerScore.ToString();
        ResetField();
    }

    private void ResetField()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
}
