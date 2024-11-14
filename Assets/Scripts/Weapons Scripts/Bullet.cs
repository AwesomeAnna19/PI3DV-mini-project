using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public class Bullet : MonoBehaviour
{
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
