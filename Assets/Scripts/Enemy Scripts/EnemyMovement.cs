using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject player;
    Rigidbody currRb;
    float speed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        currRb = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(player.transform);
        currRb.velocity = new Vector3(transform.forward.x * speed * Time.deltaTime, currRb.velocity.y, transform.forward.z * speed * Time.deltaTime);
    }
}
