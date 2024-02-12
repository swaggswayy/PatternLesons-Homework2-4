using System.Collections;
using UnityEngine;

public class BurstShot : WeaponScript
{
    [SerializeField] private int _countShots;
    [SerializeField] private float _delayBetweenShots;

    protected override void Shoot()
    {
        StartCoroutine(BurstFiring());
    }

    private IEnumerator BurstFiring()
    {
        for (int i = 0; i < _countShots; i++)
        {
            if(CurrentAmmo <= 0) yield break;
            CurrentAmmo--;
            Debug.Log(CurrentAmmo);
            BulletScript bullet = Instantiate(BulletPrefab, Muzzle.position, Quaternion.identity);
            yield return new WaitForSeconds(_delayBetweenShots);
        }
    }
}
