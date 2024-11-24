using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageGun : MonoBehaviour
{
    public float Damage;
    public float BulletRange;
    private Transform PlayerCamera;
    public GameObject laserPointPrefab;
    GameObject laserPointObject;
    Renderer laserPointRenderer;


    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera = Camera.main.transform;
        laserPointObject = Instantiate(laserPointPrefab);
        laserPointRenderer = laserPointObject.GetComponent<Renderer>();
        laserPointObject.SetActive(false);
    }

    // This is the raycast that will hit and damage the enemies.
    public void Shoot()
    {
        // Here I make the raycast.
        Ray gunRay = new Ray(PlayerCamera.position, PlayerCamera.forward);

        // Here I perform the raycast.
        if (Physics.Raycast(gunRay, out RaycastHit hitInfo, BulletRange))
        {
            // Here I visualize the raycast when it hits something.
            Debug.DrawRay(PlayerCamera.position, PlayerCamera.forward * hitInfo.distance, Color.yellow);

            if (laserPointObject != null )
            {
                // Here I position the laser object at the hit point.
                laserPointObject.transform.position = hitInfo.point;

                // Here I make sure that if the laser object isn't active, it will be active.
                if (!laserPointObject.activeSelf)
                {
                    laserPointObject.SetActive(true);
                }
            }

            // Here I make sure that when the laser/raycast hits the enemy, the enemy will take damage.
            if (hitInfo.collider.gameObject.TryGetComponent(out Enemy enemy))
            {
                enemy.Health -= Damage;
            }
            // If not anything else of the above, this code underneath will be played.
            else
            {
                // Here I will not visualize the raycast when it does not hit anything.
                Debug.DrawRay(PlayerCamera.position, PlayerCamera.forward * BulletRange, Color.white);

                if (laserPointObject != null && laserPointObject.activeSelf)
                {
                    // Here I make sure that when the laser/raycast does not hit anything, it will disable itself.
                    if (laserPointObject.activeSelf)
                    {
                        laserPointObject.SetActive(false);
                    }
                }
            }
        }
    }
}
