using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpHealthPack : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] PlayerHealth playerHealth;
    [SerializeField] FloatingHealthBar healthBar;
    float healAmount = 5f;
    string pickUpInfo;
    public GameObject healthPack;
    float snatchHealthPack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This first if statement will cast a ray to detect if it has hit any colliders around it.
        // It also has the main camera's position in world position, to make sure that the camera looks at the right object that you want to interact with.
        // Also, the ray also has the camera's forward direction - with other words, it tells you where the camera faces forward to (like a normalized vector pointing forward from the camera).
        // Lastly, the "out hit" is the output parameter, to store the information you get from when the ray hits and object (it is from RaycastHit).
        // Very lastly, the "3f" is the distance the ray travels - so when you are 3 units away from the health pack, the health pack will be detected by the ray.
        /*if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, 3f))
        {
            // This code will fetch for the health pack, get the amount of healing it does, avoid going over the max health or healing the player, and destroy the gameObject of the health packs.
            if (hit.transform.CompareTag("HealthPack") && Input.GetKeyDown(KeyCode.E))
            {
                PickUpHealth();
            }
        }*/
    }

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
