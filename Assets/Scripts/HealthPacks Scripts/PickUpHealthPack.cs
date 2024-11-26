using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpHealthPack : MonoBehaviour
{
    [SerializeField] PlayerHealth playerHealth;
    [SerializeField] FloatingHealthBar healthBar;
    float healAmount = 5f;
    public GameObject healthPack;

    void OnCollisionEnter(Collision collision)
    {
        // This code checks if the game object "playerObject" has a tag of the health pack.
        if (collision.gameObject.CompareTag("HealthPack"))
        {
            // This saves the game object as a variable.
            healthPack = collision.gameObject;

            playerHealth.health += healAmount;

            healthBar.UpdateHealthBar(playerHealth.health, playerHealth.MaxHealth);
        }
    }
}
