using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] FloatingHealthBar healthBar;
    [SerializeField] GameOverScreen gameOverScreen;
    [SerializeField] PlayerCam playerCamera;
    public float health;
    public float MaxHealth = 20f;

    // This code with the get and set functions allows acces to a private variable without directly changing the private variable in other scripts.
    public float Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
            Debug.Log(health);
            healthBar.UpdateHealthBar(health, MaxHealth);

            if (health <= 0f)
            {
                Die();
                Debug.Log("You're dead!");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    private void Die()
    {
        if (playerCamera != null)
        {
            playerCamera.enabled = false;
        }

        SceneManager.LoadScene("GameOverScreen");

        // These two codes make sure that I only can use the mouse cursor when the game over screen occurs.
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        Destroy(gameObject);
    }
}
