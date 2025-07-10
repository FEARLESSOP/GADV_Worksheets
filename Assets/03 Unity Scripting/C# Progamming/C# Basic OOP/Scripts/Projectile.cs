using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile
{
    private float speed;

    public Projectile(float speed)
    {
        this.speed = speed;
    }

    public void Fire()
    {
        if (speed > 0)
        {
            UnityEngine.Debug.Log($"Firing projectile at speed {speed}");
        }
        else
        {
            UnityEngine.Debug.Log("Cannot fire: speed too low.");
            AutoFire();
        }
    }

    public void AutoFire()
    {
        speed = 100;
        UnityEngine.Debug.Log("Speed was zero. AutoFire set speed to 100 and launched!");
    }
}

