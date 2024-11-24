using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomly : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject ground;
    float groundSize;
    float spawnTimer = 2f;
    float currentTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        groundSize = ground.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        // Here I set the current time to the time that is being played in the game (Time.deltaTime) - that is for each frame that goes by.
        currentTime += Time.deltaTime;

        // Here I check, if the current time is bigger than the spawn timer for the enemies, then the enemies will spawn in a random place on the level.
        if (currentTime > spawnTimer)
        {
            // Here it is where the enemies will spawn in random places on the level. And the enemies won't go out of bounds on the level.
            // When I divide 'ground.transform.position.x - groundSize' by 2f, I do it because it gives the distance from the center to the edge, so it defines the bounds of that side of the level.
            // For 'ground.transform.position.x - groundSize' it is the left edge of the level, 'ground.transform.position.x + groundSize' is the right edge of the level.
            // For 'ground.transform.position.z - groundSize' it is the bottom edge of the level, 'ground.transform.position.z + groundSize' is the top edge of the level.
            Vector3 spawnPosition = new Vector3(Random.Range(ground.transform.position.x - groundSize / 2f, ground.transform.position.x + groundSize / 2f), 4f, Random.Range(ground.transform.position.z - groundSize / 2f, ground.transform.position.z + groundSize / 2f));

            // Here I will spawn the enemy, on the given spawn position, and it will also know where and how it is rotated.
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            // Here I reset/restart the current time to 0, so that the enemies will surely spawn every 2 seconds/frames, and won't overlap each other (I think?).
            currentTime = 0;
        }
    }
}
