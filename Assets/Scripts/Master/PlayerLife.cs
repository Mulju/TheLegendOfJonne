using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public GameObject[] hearts;
    public static int life = 5;

    bool dead;

    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource oneUp;
    [SerializeField] private AudioSource notOneUp;

    // Singleton
    private UI myUI = UI.GetInstance();

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        myUI.UpdateLife(life, hearts);
    }

    private void Update()
    {
        //Pressing Esc key takes the game into mainmenu.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    // Removes one life and updates hearts in UI.
    public void LoseLife()
    {
        notOneUp.Play();
        life --;
        myUI.UpdateLife(life, hearts);
    }

    // Adds one life and updates hearts in UI.
    public void GainLife()
    {
        oneUp.Play();
        life ++;
        myUI.UpdateLife(life, hearts);
    }

    private void Die()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    // Detects collision with Heart/FakeHeart gameObject and Player in game, sets object inactive and adds/subtracts 1 life.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Life"))
        {
            collision.gameObject.SetActive(false);
            // If life is 10 cant gain life,
            if (life < 10)
            {
                GainLife();
            }
        }
        if (collision.gameObject.CompareTag("FakeLife"))
        {
            collision.gameObject.SetActive(false);
            LoseLife();
            // If life becomes zero Player dies.
            if (life == 0)
            {
                Die();
            }
        }
    }

    // Detects collision with Trap gameObject and Player in game.
    // Player loses one life and the scene is reloaded.
    // dead boolean prevents multiple triggers.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap") && dead == false)
        {
            LoseLife();
            // dead boolean prevents multiple triggers.
            dead = true;
            Die();
        }
    }

    // Reloads the scene.
    private void Restartevel()
    {
        // If player has lost all lives, changes bool gameOver in Playermanager to
        // change Player location to the start of the game and resets lives.
        if (life == 0)
        {
            PlayerManager.gameOver = true;
            life = 5;

            // Chooses the correct DeathScreen depending on players last scene.
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                SceneManager.LoadScene("DeathScreen");
            }
            if (SceneManager.GetActiveScene().name == "Level2")
            {
                SceneManager.LoadScene("DeathScreen2");
            }
            if (SceneManager.GetActiveScene().name == "Level1HC")
            {
                SceneManager.LoadScene("DeathScreenHC");
            }
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    //resets the level and lives when reset button is pressed in game.
    public void ResetButton()
    {
        PlayerManager.gameOver = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        life = 5;
    }
}