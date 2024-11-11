using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public float MaxHealth;
    [SerializeField] FloatingHealthBar healthBar;
    public float health;

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

            if (health < 0f)
            {
                Destroy(gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

}
