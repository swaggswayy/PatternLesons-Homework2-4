using UnityEngine;

public abstract class WeaponScript : MonoBehaviour
{
    [SerializeField] protected Transform Muzzle;
    [SerializeField] protected BulletScript BulletPrefab;
    [SerializeField] protected int CurrentAmmo;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    protected virtual void Shoot() 
    {
        if (CurrentAmmo <= 0) return;
        CurrentAmmo--;
        Debug.Log(CurrentAmmo);
        BulletScript bullet = Instantiate(BulletPrefab, Muzzle);
    }
}
