using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreakoutGameManager : MonoBehaviour
{
    public BreakoutBall ball { get; private set; }
    public BreakoutPaddle paddle { get; private set; }
    public Bricks[] bricks { get; private set; }

    public int level = 1;
    public int score = 0;
    public int lives = 3;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        this.score = 0;
        this.lives = 3;

        LoadLevel(1);
    }

    private void LoadLevel(int level)
    {
        this.level = level;

        //SceneManager.LoadScene("BreakoutLevel" + level);
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        this.ball = FindObjectOfType<BreakoutBall>();
        this.paddle = FindObjectOfType<BreakoutPaddle>();
        this.bricks = FindObjectsOfType<Bricks>();
    }

    public void Hit(Bricks bricks)
    {
        this.score += bricks.points;

        //if (Cleared())
        //{
        //    LoadLevel(this.level + 1);
        //}
    }

    private void Reset()
    {
        this.ball.ResetBall();
        this.paddle.ResetPaddle();

        if (lives <= 0)
        {
            for (int i = 0; i < this.bricks.Length; i++)
            {
                this.bricks[i].ResetBrick();
            }
        }
    }

    private void GameOver()
    {
        //NewGame();
        this.ball.gameObject.SetActive(false);
        this.paddle.gameObject.SetActive(false);
    }

    public void Dead()
    {
        this.lives--;

        if (this.lives > 0)
        {
            Reset();
        }
        else
        {
            GameOver();
        }
    }

    //private bool Cleared()
    //{
    //    for (int i = 0; i < this.bricks.Length; i++)
    //    {
    //        if (this.bricks[i].gameObject.activeInHierarchy && !this.bricks[i].unbreakable)
    //        {
    //            return false;
    //        }
    //    }

    //    return true;
    //}
}
