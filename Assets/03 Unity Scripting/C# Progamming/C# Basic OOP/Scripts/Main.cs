using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        // Test Projectile
        Projectile projectile = new Projectile(0);
        projectile.Fire();

        // Test Player
        Player player = new Player(10);
        player.TakeDamage(3);
        Debug.Log($"Player health: {player.GetHealth()}");

        // Test TreasureChest
        AncientChest ancientChest = new AncientChest();
        ancientChest.Unlock();
        ancientChest.Shake();

        MagicChest magicChest = new MagicChest();
        magicChest.Unlock();
        magicChest.Shake();

        TreasureChest chestWithToken = new TreasureChest();
        chestWithToken.Unlock(true);
    }
}
