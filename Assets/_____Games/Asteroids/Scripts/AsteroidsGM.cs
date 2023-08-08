using UnityEngine;

public class AsteroidsGM : MonoBehaviour
{
    public AsteroidsPlayer player;
    public ParticleSystem explosion;
    public int lives = 3;
    public float respawnTime = 3f;
    public float respawnInvulnerabilityTime = 3f;
    public int score = 0;

    public void AsteroidDestoyed(Asteroids asteroid)
    {
        this.explosion.transform.position = asteroid.transform.position;
        this.explosion.Play();

        if (asteroid.size < 0.75f)
        {
            this.score += 100;
        }
        else if(asteroid.size < 1.15f)
        {
            this.score += 50;
        }
        else
        {
            this.score += 25;
        }
    }

    public void PlayerDied()
    {
        this.explosion.transform.position = this.player.transform.position;
        this.explosion.Play();

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
        this.lives = 3;
        this.score = 0;

        Invoke(nameof(Respawn), this.respawnTime); 
    }
}
