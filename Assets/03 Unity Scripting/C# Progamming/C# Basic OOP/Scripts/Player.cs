using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int health;

    public Player(int startingHealth)
    {
        health = startingHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0)
        {
            health = 0;
        }
    }

    public int GetHealth()
    {
        return health;
    }
}

