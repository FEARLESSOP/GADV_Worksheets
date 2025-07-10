using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest
{
    public virtual void Unlock()
    {
        UnityEngine.Debug.Log("You unlock the treasure chest.");
    }

    public void Unlock(bool hasToken)
    {
        if (hasToken)
        {
            UnityEngine.Debug.Log("You unlock the treasure chest with a special token and get bonus treasure!");
        }
        else
        {
            Unlock();
        }
    }

    public void Shake()
    {
        UnityEngine.Debug.Log("You hear something rattle inside the chest.");
    }
}
