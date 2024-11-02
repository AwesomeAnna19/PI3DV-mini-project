using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // This is the "lifespan" of the bullet - so after 3 seconds it will "die".
    public float life = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // When the game starts the bullets are destroyed (so just "invisible").
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        // This code checks if the game object "enemyObject" has a tag of the enemy.
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // This saves the game object as a variable.
            GameObject enemyObject = collision.gameObject;
            
            // Here I fetch for the Enemy script and use the Health get and set functions and minus 1 each time I shoot a bullet on the enemy.
            enemyObject.GetComponent<Enemy>().Health--;

            // When the bullets collide with the enemy game object, then it will be destroyed.
            Destroy(gameObject);
        }
    }
}
