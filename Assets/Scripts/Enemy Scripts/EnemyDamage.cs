using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        // This code checks if the game object "playerObject" has a tag of the enemy.
        if (collision.gameObject.CompareTag("Player"))
        {
            // This saves the game object as a variable.
            playerObject = collision.gameObject;

            // Here I fetch for the PlayerHealth script and use the Health get and set functions and minus 1 each time I shoot a bullet on the enemy.
            playerObject.GetComponent<PlayerHealth>().Health--;
        }
    }
}