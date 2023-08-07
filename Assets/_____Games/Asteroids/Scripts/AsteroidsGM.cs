using UnityEngine;

public class AsteroidsGM : MonoBehaviour
{
    public AsteroidsPlayer player;
    public int lives = 3;
    public float respawnTime = 3f;
    public float respawnInvulnerabilityTime = 3f;
    public void PlayerDied()
    {
        this.lives--;

        if (this.lives <= 0)
        {
            GameOver();
        }
        else
        {
            Invoke(nameof(Respawn), this.respawnTime);
        }
    }

    private void Respawn()
    {
        this.player.transform.position = Vector3.zero;
        this.player.gameObject.layer = LayerMask.NameToLayer("Invulnerable");
        this.player.gameObject.SetActive(true);
        
        Invoke(nameof(TurnOnCollisions), this.respawnInvulnerabilityTime);
    }

    private void TurnOnCollisions()
    {
        this.player.gameObject.layer = LayerMask.NameToLayer("Player");
    }

    private void GameOver()
    {

    }
}
