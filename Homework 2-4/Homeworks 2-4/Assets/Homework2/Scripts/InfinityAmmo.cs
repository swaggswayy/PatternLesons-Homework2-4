using UnityEngine;

public class InfinityAmmo : WeaponScript
{
    protected override void Shoot()
    {
        BulletScript bullet = Instantiate(BulletPrefab, Muzzle);
    }
}
