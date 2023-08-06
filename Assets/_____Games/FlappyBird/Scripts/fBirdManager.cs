using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fBirdManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public fBirdPlayer player;

    public void Awake()
    {
        Application.targetFrameRate = 60;

        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        gameOver.SetActive(false);
        playButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
