using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AncientChest : TreasureChest
{
    public override void Unlock()
    {
        UnityEngine.Debug.Log("You unlock the ancient chest with an ancient key.");
    }
}
