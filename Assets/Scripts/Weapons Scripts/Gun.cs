using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gun : MonoBehaviour
{
    // Custom gun behaviors
    public UnityEvent OnGunShoot;

    // Some seconds delay after having shot some bullets, acts like a buffer
    public float FireCoolDown;

    // By default gun is semi
    // It will determine whether or not a given instance of the gun is a automatic or semi-gun (so how many bullets it shoots)
    public bool Automatic;

    // It will store the current cooldown of the given weapon instance
    private float CurrentCoolDown;

    // This is for my particle when shooting.
    public GameObject particlePrefab;

    // This is where the particle will spawn when activated.
    public Transform spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        // Here we set the current cooldown to the fire cooldown
        CurrentCoolDown = FireCoolDown;
    }

    // Update is called once per frame
    // Two similar functions, that makes functionalities for semi and automatic firing from the gun
    void Update()
    {
        // This is for the automatic firing
        if (Automatic)
        {
            // Checks if the left mouse button is being held down
            if (Input.GetMouseButton(0))
            {
                // Checks if the current cooldown is less than or equal to 0 seconds
                if (CurrentCoolDown <= 0f)
                {
                    // If yes, then it invokes the ongoing shoot event handler
                    OnGunShoot?.Invoke();
                    CurrentCoolDown = FireCoolDown;
                    ShootingSpawnParticle();
                }
            }
        }
        // This is for the semi firing
        else
        {
            // Checks if a mouse button is pressed within a given frame
            if (Input.GetMouseButtonDown(0))
            {
                if (CurrentCoolDown <= 0f)
                {
                    OnGunShoot?.Invoke();
                    CurrentCoolDown = FireCoolDown;
                    ShootingSpawnParticle();
                }
            }
        }

        // Subtracts the frame delta time to the current cooldown
        CurrentCoolDown -= Time.deltaTime;
    }

    // This void will instantiate the particles that resembled shooting.
    public void ShootingSpawnParticle()
    {
        Instantiate(particlePrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
